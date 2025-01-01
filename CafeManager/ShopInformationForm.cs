using BusinessApplicationLayer;
using BusinessEntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManager
{
    public partial class ShopInformationForm : Form
    {
        private readonly SettingsService _settingsService;
        private string logoImage;
        public ShopInformationForm(SettingsService settingsService)
        {
            InitializeComponent();
            _settingsService = settingsService;
        }

        private async Task<string> GetSettingValueAsync(int settingsId)
        {
            var searchParameters = new Dictionary<string, object> { { "SettingsID", settingsId } };
            var settings = await Task.Run(() => _settingsService.GetSettingByField(searchParameters));
            return settings.FirstOrDefault()?.SettingsValue;
        }


        private async Task UpdateSettingsAsync(List<Settings> settingsList)
        {
            try
            {
                await Task.Run(() =>
                {
                    foreach (var setting in settingsList)
                    {
                        _settingsService.EditSetting(setting);
                    }
                });

                MessageBox.Show("All settings updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void ShopInformationForm_Load(object sender, EventArgs e)
        {
            string manualDescriptionText = await GetSettingValueAsync(9) ?? "Not set";
            string manualAddressText = await GetSettingValueAsync(7) ?? "Not set";

            txtShopName.Text = await GetSettingValueAsync(6) ?? "Not set";
            txtShopAddress.Text = manualAddressText.Replace(@"\r\n", Environment.NewLine);
            txtInvoiceDescription.Text = manualDescriptionText.Replace(@"\r\n", Environment.NewLine);
            txtPhoneNumber.Text = await GetSettingValueAsync(8) ?? "Not set";

            string logoPath = await GetSettingValueAsync(5); 
            if (!string.IsNullOrWhiteSpace(logoPath) && File.Exists(logoPath))
            {
                picLogo.ImageLocation = logoPath;
                logoImage = logoPath;
            }
            else
            {
                picLogo.Image = Properties.Resources.cat_hotchok2;
                logoImage = "null";
            }
        }

        private void txtInvoiceDescription_TextChanged(object sender, EventArgs e)
        {
            int maxLines = 3;
            int maxLength = 120; 
            int maxCharsPerLine = 40; 

    
            if (txtInvoiceDescription.Text.Length > maxLength)
            {
                MessageBox.Show($"Maximum {maxLength} characters are allowed.");
                txtInvoiceDescription.Text = txtInvoiceDescription.Text.Substring(0, maxLength);
                txtInvoiceDescription.SelectionStart = txtInvoiceDescription.Text.Length;
                return;
            }

            string[] lines = txtInvoiceDescription.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            if (lines.Length > maxLines)
            {
                MessageBox.Show($"Only {maxLines} lines are allowed.");
                txtInvoiceDescription.Text = string.Join(Environment.NewLine, lines.Take(maxLines));
                txtInvoiceDescription.SelectionStart = txtInvoiceDescription.Text.Length;
                return;
            }

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > maxCharsPerLine)
                {
                    MessageBox.Show($"Each line can only have up to {maxCharsPerLine} characters.");
                    lines[i] = lines[i].Substring(0, maxCharsPerLine);
                }
            }

            txtInvoiceDescription.Text = string.Join(Environment.NewLine, lines);
            txtInvoiceDescription.SelectionStart = txtInvoiceDescription.Text.Length;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    picLogo.ImageLocation = filePath;
                    logoImage = filePath;
                }
            }
        }

        private async void btnInfoEdit_Click(object sender, EventArgs e)
        {
            var settingsList = new List<Settings>
            {
                new Settings
                {
                    SettingsID = 6,
                    SettingsKey = "ShopName",
                    SettingsValue = txtShopName.Text
                },
                new Settings
                {
                    SettingsID = 7,
                    SettingsKey = "CafeAddress",
                    SettingsValue = txtShopAddress.Text
                },
                new Settings
                {
                    SettingsID = 8,
                    SettingsKey = "PhoneNumber",
                    SettingsValue = txtPhoneNumber.Text
                },
                new Settings
                {
                    SettingsID = 9,
                    SettingsKey = "InvoiceDescription",
                    SettingsValue = txtInvoiceDescription.Text
                },
                 new Settings
                {
                    SettingsID = 5,
                    SettingsKey = "LogoPath",
                    SettingsValue = logoImage
                }
            };

            await UpdateSettingsAsync(settingsList);
        }
    }
}
