using BusinessApplicationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CafeManager
{
    public partial class LoginForm : Form
    {
        private readonly SettingsService _settingsService;
        private string _pass;
        public LoginForm(SettingsService settingsService)
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

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            _pass= await GetSettingValueAsync(1);
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {

            lblPassWarning.Visible = false;
            if (e.KeyChar == '\r')
            {
                if (_pass == txtLogin.Text)
                {
                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    mainForm.Show();
                }
                else
                {
                    SystemSounds.Exclamation.Play();
                    lblPassWarning.Visible = true;                    
                }
                    
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
