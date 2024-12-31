using BusinessEntitiesLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManager
{
    public static class ControlLoader
    {
        public static Button CreateButton(string name, string text, Image backgroundImage, Size size, Padding margin, DockStyle dock = DockStyle.None)
        {
            return new Button
            {
                Name = name,
                Text = text,
                BackgroundImage = backgroundImage,
                BackgroundImageLayout = ImageLayout.Center,
                Size = size,
                Margin = margin,
                Dock = dock
            };
        }

        public static Label CreateLabel(string text, DockStyle dockStyle, Padding margin, ContentAlignment textAlign, float fontSize, FontStyle fontStyle)
        {
            return new Label
            {
                Text = text,
                AutoSize = false,
                Dock = dockStyle,
                Margin = margin
            };
        }

        public static TextBox CreateTextBox(string name, DockStyle dockStyle, string defaultText,bool readOnly)
        {
            return new TextBox
            {
                Name = name,
                Dock = dockStyle,
                Text = defaultText,
                TabStop = false,
                ReadOnly = readOnly
            };
        }

        public static GroupBox CreateGroupBox(string name, DockStyle dockStyle)
        {
            return new GroupBox
            {
                Name = name,
                Dock = dockStyle
            };
        }

        public static TableLayoutPanel CreateTableLayoutPanel(int columnCount, int rowCount, DockStyle dockStyle,int padding)
        {
            return new TableLayoutPanel
            {
                Dock = dockStyle,
                ColumnCount = columnCount,
                RowCount = rowCount,
                Padding = new Padding(padding)
            };
        }
        public static DataGridView CreateDataGridView(bool readOnly, DataGridViewAutoSizeColumnsMode autoSizeMode)
        {
            return new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = autoSizeMode
            };
        }


        public static DataGridViewColumn CreateGridColumn(string name, string headerText, int width, bool readOnly, bool visible = true)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = headerText,
                Width = width,
                ReadOnly = readOnly,
                Visible = visible
            };
        }

        public static DataGridView CreateConfiguredDataGridView(DataGridViewColumn[] columns, Action<DataGridView> configureEvents = null)
        {
            var grid = CreateDataGridView(true, DataGridViewAutoSizeColumnsMode.Fill);

            grid.Columns.AddRange(columns);

            grid.AllowUserToAddRows = false;

            configureEvents?.Invoke(grid);

            return grid;
        }

        public static Panel CreatePanel(BorderStyle borderStyle, bool visible)
        {
            return new Panel
            {
                BorderStyle = borderStyle,
                Visible = visible
            };
        }


        public static TabControl CreateTabControl(string name, DockStyle dock, TabSizeMode sizeMode, Size itemSize)
        {
            return new TabControl
            {
                Name = name,
                Dock = dock,
                SizeMode = sizeMode,
                ItemSize = itemSize
            };
        }

        public static TabPage CreateTabPage(string name, string text)
        {
            return new TabPage
            {
                Name = name,
                Text = text
            };
        }



        public static RadioButton CreateRadioButton(string text, string name, bool isChecked, DockStyle dock = DockStyle.None)
        {
            return new RadioButton
            {
                Text = text,
                Name = name,
                Checked = isChecked,
                Dock = dock
            };
        }

        public static CheckBox CreateCheckBox(string text, string name, bool isChecked, DockStyle dock = DockStyle.None)
        {
            return new CheckBox
            {
                Text = text,
                Name = name,
                Checked = isChecked,
                Dock = dock
            };
        }



        public static void SetDropdownPosition(Panel dropdownPanel, Control triggerControl)
        {
            dropdownPanel.Location = new Point(triggerControl.Left + 18, triggerControl.Bottom + 30);
            dropdownPanel.Width = triggerControl.Width;
        }

    }
}
