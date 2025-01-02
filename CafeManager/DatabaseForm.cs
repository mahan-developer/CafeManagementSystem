using Microsoft.Win32;
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessApplicationLayer;
using BusinessEntitiesLayer;
using CommonUtilities;

namespace CafeManager
{
    public partial class DatabaseForm : Form
    {
        private readonly DatabaseInitializerService _dbService;
        private readonly SettingsService _settingsService;
        private readonly CustomerService _customerService;
        private readonly List<string> tableNames = new List<string> { "CafeMenuItem", "Customer", "Invoice", "InvoiceItem", "CafeMenuItemSize", "CafeMenuItemSizeCategory", "CafeMenuCategory", "Settings" };

        public DatabaseForm(DatabaseInitializerService dbService, SettingsService settingsService, CustomerService customerService)
        {
            InitializeComponent();
            _dbService = dbService ?? throw new ArgumentNullException(nameof(dbService));
            _settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));
            _customerService = customerService ?? throw new ArgumentNullException(nameof(customerService));
        }

        private async Task<string> GetSettingValueAsync(int settingsId)
        {
            var searchParameters = new Dictionary<string, object> { { "SettingsID", settingsId } };
            var settings = await Task.Run(() => _settingsService.GetSettingByField(searchParameters));
            return settings.FirstOrDefault()?.SettingsValue;
        }

        private async void DatabaseForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (!_dbService.CheckSQLServerExists())
                {
                    UpdateLabelStatus(lblSqlInfo, "SQL Server is not installed or available.", Color.Red);
                    lblDatabaseInfo.Visible= false;
                    lblTablesInfo.Visible= false;
                    return;
                }
                else
                {
                    lblDatabaseInfo.Visible = true;
                    lblTablesInfo.Visible = true;
                    groupBox7.Enabled = true;
                }
                    groupBox7.Enabled = true;

                UpdateLabelStatus(lblSqlInfo, "SQL Server is available.", Color.Green);

                if (!_dbService.CheckDatabaseExists())
                {
                    UpdateLabelStatus(lblDatabaseInfo, "Database does not exist.", Color.Red);
                    return;
                }

                UpdateLabelStatus(lblDatabaseInfo, "Database exists.", Color.Green);

                if (!_dbService.CheckTablesExist(tableNames))
                {
                    UpdateLabelStatus(lblTablesInfo, "Tables do not exist.", Color.Red);
                    return;
                }

                UpdateLabelStatus(lblTablesInfo, "Tables exist.", Color.Green);
                groupBox9.Enabled = true;

                lblBackupPath.Text = await GetSettingValueAsync(2) ?? "Not set";
                chkAutoBackup.Checked = (await GetSettingValueAsync(3)) == "true";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dbService.CreateDatabaseIfNotExists())
                {
                    MessageBox.Show("Database created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateLabelStatus(lblDatabaseInfo, "Database exists.", Color.Green);
                }
                else
                {
                    MessageBox.Show("Database already exists. No need to create it.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            try
            {
                var entityTypes = new List<Type>
                {
                    typeof(Customer),
                    typeof(Invoice),
                    typeof(InvoiceItem),
                    typeof(CafeMenuItem),
                    typeof(CafeMenuItemSize),
                    typeof(CafeMenuItemSizeCategory),
                    typeof(CafeMenuCategory),
                    typeof(Settings)
                };

                if (!_dbService.CheckDatabaseExists())
                {
                    MessageBox.Show("Database does not exist. Create the database first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (_dbService.CheckTablesExist(tableNames))
                    {
                        MessageBox.Show("Tables already exist. No need to create them.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        _dbService.CreateTablesAndProceduresIfNotExists(entityTypes);
                        MessageBox.Show("Tables created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UpdateLabelStatus(lblTablesInfo, "Tables exist.", Color.Green);
                        groupBox9.Enabled = true;
                        _settingsService.AddDefaultSetting();
                        _customerService.AddDefaultCustomer();
                        MainForm parentForm = this.MdiParent as MainForm;
                        parentForm.ActiveRBN();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackupDatabase_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select a folder for the backup.";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;
                    string backupFileName = $"DatabaseBackup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
                    string backupPath = Path.Combine(folderPath, backupFileName);

                    try
                    {
                        if (_dbService.BackupDatabase(backupPath))
                        {
                            MessageBox.Show($"Backup created successfully.\nPath: {backupPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRestoreDatabase_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select the backup file.";
                openFileDialog.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string backupFilePath = openFileDialog.FileName;

                    try
                    {
                        if (_dbService.RestoreDatabase(backupFilePath))
                        {
                            MessageBox.Show("Database restored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void btnSelectDefaultDbPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Please select a folder for auto backup";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;

                    try
                    {
                        var setting = new Settings
                        {
                            SettingsID = 2,
                            SettingsKey = "BackupPath",
                            SettingsValue = folderPath
                        };

                        await Task.Run(() => _settingsService.EditSetting(setting));
                        lblBackupPath.Text = folderPath;
                        MessageBox.Show("Default backup path updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void chkAutoBackup_Click(object sender, EventArgs e)
        {
            if (chkAutoBackup.Checked)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to activate auto backup?",
                                                    "Confirm Activation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var setting = new Settings
                    {
                        SettingsID = 3,
                        SettingsKey = "AutoBackup",
                        SettingsValue = "true"
                    };

                    await Task.Run(() => _settingsService.EditSetting(setting));
                    if(!Directory.Exists(lblBackupPath.Text))
                        Directory.CreateDirectory(lblBackupPath.Text);
                    MessageBox.Show("Auto backup successfully activated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure you want to deactivate auto backup?",
                                                    "Confirm Deactivation",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    var setting = new Settings
                    {
                        SettingsID = 3,
                        SettingsKey = "AutoBackup",
                        SettingsValue = "false"
                    };

                    await Task.Run(() => _settingsService.EditSetting(setting));
                    MessageBox.Show("Auto backup successfully deactivated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        private void UpdateLabelStatus(Label label, string text, Color color)
        {
            label.Text = text;
            label.ForeColor = color;
        }
    }
}

