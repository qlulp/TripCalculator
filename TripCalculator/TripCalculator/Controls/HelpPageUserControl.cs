using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using TripCalculator.Properties;

namespace TripCalculator.Controls
{
    public partial class SettingsPage : UserControl
    {
        bool IsAnimationActive = false;
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SlidePanelRight(Control control, int delay)
        {
            control.Width = 188;
        }

        private void SlidePanelLeft(Control control, int delay)
        {
            control.Width = 38;
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public async void Show(int Heigth)
        {
            if (!IsAnimationActive)
            {
                IsAnimationActive = true;
                do
                {
                    this.Height += 20;
                    await Task.Delay(2);
                } while (this.Height <= Heigth);
                IsAnimationActive = false;
            }
        }

        public async void Close()
        {
            if (!IsAnimationActive)
            {
                IsAnimationActive = true;
                do
                {
                    this.Height -= 30;
                    await Task.Delay(2);
                } while (this.Height > 0);
                IsAnimationActive = false;
            }
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            Color themeColor = Settings.Default.ThemeColor;

            this.BackColor = themeColor;
            ThemeLabel.ForeColor = themeColor;
            HideButton.ForeColor = themeColor;
            LinePanel.BackColor = themeColor;
            SelectThemeColor();
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            Settings.Default.ThemeColor = (sender as Guna2Panel).FillColor;
            Settings.Default.Save();

            SettingsPage_Load(null, null);
            SelectThemeColor();
        }

        private void SelectThemeColor()
        {
            Color themeCOlor = Settings.Default.ThemeColor;
            foreach (var colorPanel in ThemePanel.Controls.OfType<Guna2Panel>())
            {
                if (colorPanel.FillColor == themeCOlor)
                {
                    colorPanel.ShadowDecoration.Enabled = true;
                }
                else
                {
                    colorPanel.ShadowDecoration.Enabled = false;
                }
            }
        }
    }
}
