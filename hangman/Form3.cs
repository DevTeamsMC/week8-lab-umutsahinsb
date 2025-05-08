using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hangman
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] { "Genel", "Tarih", "Coğrafya", "Matematik" });
            comboBox2.Items.AddRange(new string[] { "Kolay", "Orta", "Zor" });
            comboBox3.Items.AddRange(new string[] { "Cicek", "Adam" });

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedItem = GameSettings.ImageTheme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameSettings.SelectedCategory = comboBox1.SelectedItem.ToString();
            GameSettings.SelectedDifficulty = comboBox2.SelectedItem.ToString();
            GameSettings.ImageTheme = comboBox3.SelectedItem.ToString();
            MessageBox.Show("Ayarlar kaydedildi.");
            this.Close();
        }
    }
}
