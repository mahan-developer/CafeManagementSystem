using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonUtilities
{
    public class ControlHelper
    {
        public static void ClearControls(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty; 
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false; 
                }
                
            }
        }


        public static void ClearControlsInContainer(params Control[] containers)
        {
            foreach (var container in containers)
            {
                if (container == null)
                    continue;
                foreach (Control control in container.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Text = string.Empty;
                    }
                    else if (control is ComboBox comboBox)
                    {
                        comboBox.SelectedIndex = -1;
                    }
                    else if (control is CheckBox checkBox)
                    {
                        checkBox.Checked = false;
                    }
                    else if (control is DataGridView gridview)
                    {
                        gridview.Rows.Clear();
                    }

 
                    if (control.HasChildren)
                    {
                        ClearControlsInContainer(control);
                    }
                }
            }
        }



        public static bool AreControlsFilled(params Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
                else if (control is ComboBox comboBox && comboBox.SelectedIndex == -1)
                {
                    return false;
                }
                else if (control is CheckBox checkBox && !checkBox.Checked)
                {
                    return false;
                }
            }
            return true;
        }



    }
}
