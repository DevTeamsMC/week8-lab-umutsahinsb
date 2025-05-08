namespace hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GameSettings.SelectedCategory) || string.IsNullOrEmpty(GameSettings.SelectedDifficulty))
            {
                MessageBox.Show("Lütfen önce Ayarlar kýsmýndan kategori ve zorluk seçin.");
                return;
            }

            switch (GameSettings.SelectedDifficulty)
            {
                case "Kolay":
                    GameSettings.TimeLimit = 90;
                    break;
                case "Orta":
                    GameSettings.TimeLimit = 60;
                    break;
                case "Zor":
                    GameSettings.TimeLimit = 30;
                    break;
            }

            Form2 gameForm = new Form2();
            gameForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form3 ayarForm = new Form3();
            ayarForm.ShowDialog();
        }
    }
}