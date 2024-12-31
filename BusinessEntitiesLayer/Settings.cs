using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{
    public class Settings
    {
        private int _settingsID;
        public int SettingsID
        {
            get { return _settingsID; }
            set { _settingsID = value; }
        }


        private string _settingsKey;
        [Column("NVARCHAR", 50)]
        public string SettingsKey
        {
            get { return _settingsKey; }
            set { _settingsKey = value; }
        }

        private string _settingsValue;
        [Column("NVARCHAR", 250)]
        public string SettingsValue
        {
            get { return _settingsValue; }
            set { _settingsValue = value; }
        }
    }
}
