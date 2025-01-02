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

namespace CafeManager
{
    public partial class GeneralSettingsForm : Form
    {
        private readonly SettingsService _settingsService;
        private string filePath;
        private string oldPass;
        public GeneralSettingsForm(SettingsService settingsService)
        {
            InitializeComponent();
            _settingsService = settingsService;
        }

        private string GetSettingValueAsync(int settingsId)
        {
            var searchParameters = new Dictionary<string, object> { { "SettingsID", settingsId } };

            var settings = _settingsService.GetSettingByField(searchParameters);

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

                MessageBox.Show("settings updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ImageLayoutCheck()
        {
            if (cmbPictureMode.Text == "Stretch")
                picPreview.BackgroundImageLayout = ImageLayout.Stretch;
            if (cmbPictureMode.Text == "Tile")
                picPreview.BackgroundImageLayout = ImageLayout.Tile;
            if (cmbPictureMode.Text == "Center")
                picPreview.BackgroundImageLayout = ImageLayout.Center;
            if (cmbPictureMode.Text == "Zoom")
                picPreview.BackgroundImageLayout = ImageLayout.Zoom;
            if (cmbPictureMode.Text == "Normal")
                picPreview.BackgroundImageLayout = ImageLayout.None;
        }



        private void GeneralSettingsForm_Load(object sender, EventArgs e)
        {
            oldPass= GetSettingValueAsync(1);

            cmbPictureMode.Text = GetSettingValueAsync(10);
            string backgroundImagePath = GetSettingValueAsync(4);
            filePath = backgroundImagePath;
            if (backgroundImagePath == "null")
            {
                picPreview.BackgroundImage = Properties.Resources.cat_hotchok2;
                picPreview.BackgroundImageLayout = ImageLayout.Center;
            }
            else
            {
                if (File.Exists(backgroundImagePath))
                {
                    picPreview.BackgroundImage = Image.FromFile(backgroundImagePath);
                    ImageLayoutCheck();
                }
                else
                {
                    picPreview.BackgroundImage = Properties.Resources.cat_hotchok2;
                    picPreview.BackgroundImageLayout = ImageLayout.Center;
                }
            }
        }


       

        private void btnSelectBackgroundImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    picPreview.BackgroundImage =Image.FromFile(filePath);

                    ImageLayoutCheck();
                }
            }
        }



        private void cmbPictureMode_SelectedValueChanged(object sender, EventArgs e)
        {
            ImageLayoutCheck();
        }

        private async void btnImageEdit_Click(object sender, EventArgs e)
        {

            var settingsList = new List<Settings>
            {
                new Settings
                {
                    SettingsID = 4,
                    SettingsKey = "BackgroundImage",
                    SettingsValue = filePath
                },
                new Settings
                {
                    SettingsID = 10,
                    SettingsKey = "ImageMode",
                    SettingsValue = cmbPictureMode.Text
                }
            };

            await UpdateSettingsAsync(settingsList);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == oldPass)
            {
                if (txtNewPassword.Text == txtRepeatPassword.Text)
                {
                    var settingsList = new List<Settings>
                    {
                        new Settings
                        {
                            SettingsID = 1,
                            SettingsKey = "Password",
                            SettingsValue = txtNewPassword.Text
                        }
                    };
                    await UpdateSettingsAsync(settingsList);
                    oldPass = txtNewPassword.Text;
                }
                else
                    MessageBox.Show("The new password and its confirmation do not match", "Password update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("The old password is wrong", "Password update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
