using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace ChromiumTest
{
    public partial class Settings : Office2007Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Homepage;
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Contains("https://") || textBox1.Text.Contains("http://") || textBox1.Text.Contains(".com") || textBox1.Text.Contains(".net") || textBox1.Text.Contains(".org") || textBox1.Text.Contains(".nl") || textBox1.Text.Contains(".be") || textBox1.Text.Contains(".de"))
                {
                    Properties.Settings.Default.Homepage = textBox1.Text;
                    MessageBox.Show("Homepage has been set to " + textBox1.Text, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Enter a valid URL!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("There's no text in the textbox!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dButton_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Homepage = "http://google.com";
            textBox1.Text = Properties.Settings.Default.Homepage;
            MessageBox.Show("Homepage has been set to default!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
