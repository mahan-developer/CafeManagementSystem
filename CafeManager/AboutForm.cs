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

namespace CafeManager
{
    public partial class AboutForm : Form
    {
        private readonly SettingsService _settingsService;
        private string _version;
        public AboutForm(SettingsService settingsService)
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

        private async void AboutForm_Load(object sender, EventArgs e)
        {
            _version = await GetSettingValueAsync(11);
            lblAppVersion.Text = "Version: " + _version;
        }
    }
}
