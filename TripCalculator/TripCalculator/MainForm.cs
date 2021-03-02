using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripCalculator.Properties;

namespace TripCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CLoseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LitersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PriceTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ConsumptionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpHoverPanel.Show(this.Height);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (!LitersTextBox.Text.Equals(string.Empty) && !ConsumptionTextBox.Text.Equals(string.Empty) && !PriceTextBox.Text.Equals(string.Empty))
            {
                double liters = double.Parse(LitersTextBox.Text.Replace('.', ','));
                double consumption = double.Parse(ConsumptionTextBox.Text.Replace('.', ','));
                double price = double.Parse(PriceTextBox.Text.Replace('.', ','));

                // MoneyResult.Text = (liters * price).ToString("##.##") + "р.";
                DistanceLabel.Text = (100 / consumption * liters).ToString("##.##") + " км.";
                TravelCostLabel.Text = (liters * price).ToString() + "р." ;
        } }

        private void DistanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            Color themeColor = Settings.Default.ThemeColor;

            BottomPanel.FillColor = themeColor;
            HelpButton.FillColor = themeColor;
            TitleLabel.ForeColor = themeColor;
            InputPanel.BorderColor = themeColor;
            LitersLabel.ForeColor = themeColor;
            ConsumptionLabel.ForeColor = themeColor;
            PriceLabel.ForeColor = themeColor;
            Line1.BackColor = themeColor;
            Line2.BackColor = themeColor;
            CalculateButton.FillColor = themeColor;
        }

        private void InputPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HelpHoverPanel_BackColorChanged(object sender, EventArgs e)
        {
            MainForm_Load(null, null);
        }
    }
}
