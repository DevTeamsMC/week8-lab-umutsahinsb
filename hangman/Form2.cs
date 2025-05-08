using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Timers;


namespace hangman
{
    public partial class Form2 : Form
    {
        private class Question
        {
            public string Word { get; set; }
            public string Clue { get; set; }
            public string Category { get; set; }
            public string Difficulty { get; set; }
        }

        private List<Question> allQuestions = new List<Question>()
        {
           new Question { Word = "telefon", Clue = "Çok amaçlı taşınabilir cihaz", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "televizyon", Clue = "Görüntü aktaran elektronik cihaz", Category = "Genel", Difficulty = "Orta" },
new Question { Word = "internet", Clue = "Dijital iletişim ağı", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "kitap", Clue = "Bilgi kaynağı", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "kalem", Clue = "Yazı aracı", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "masa", Clue = "Üzerinde çalışılan mobilya", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "sandalye", Clue = "Üzerine oturulan eşya", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "bilgisayar", Clue = "Veri işleyen elektronik cihaz", Category = "Genel", Difficulty = "Orta" },
new Question { Word = "radyo", Clue = "Sesli yayın aygıtı", Category = "Genel", Difficulty = "Orta" },
new Question { Word = "kamera", Clue = "Görüntü kaydeden cihaz", Category = "Genel", Difficulty = "Zor" },
new Question { Word = "uçak", Clue = "Havada seyahat aracı", Category = "Genel", Difficulty = "Orta" },
new Question { Word = "tren", Clue = "Raylarda ilerleyen taşıt", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "otobüs", Clue = "Toplu taşıma aracı", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "bisiklet", Clue = "İki tekerlekli araç", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "robot", Clue = "Yapay zekalı makine", Category = "Genel", Difficulty = "Zor" },
new Question { Word = "futbol", Clue = "Topla oynanan takım oyunu", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "tenis", Clue = "Raketle oynanan spor", Category = "Genel", Difficulty = "Orta" },
new Question { Word = "sinema", Clue = "Film gösterilen yer", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "tiyatro", Clue = "Sahne sanatı", Category = "Genel", Difficulty = "Orta" },
new Question { Word = "oyun", Clue = "Eğlence amacıyla yapılan etkinlik", Category = "Genel", Difficulty = "Kolay" },
new Question { Word = "roma", Clue = "İtalya'nın başkenti", Category = "Tarih", Difficulty = "Kolay" },
new Question { Word = "hitit", Clue = "Anadolu'da kurulmuş antik uygarlık", Category = "Tarih", Difficulty = "Zor" },
new Question { Word = "bizans", Clue = "Doğu Roma İmparatorluğu", Category = "Tarih", Difficulty = "Orta" },
new Question { Word = "osmanlı", Clue = "600 yıl hüküm süren imparatorluk", Category = "Tarih", Difficulty = "Kolay" },
new Question { Word = "cumhuriyet", Clue = "1923'te ilan edilen yönetim şekli", Category = "Tarih", Difficulty = "Kolay" },
new Question { Word = "ataturk", Clue = "Türkiye Cumhuriyeti kurucusu", Category = "Tarih", Difficulty = "Kolay" },
new Question { Word = "kurtuluş", Clue = "Milli Mücadele dönemi", Category = "Tarih", Difficulty = "Orta" },
new Question { Word = "inkılap", Clue = "Devrim niteliğinde değişim", Category = "Tarih", Difficulty = "Orta" },
new Question { Word = "imparator", Clue = "Mutlak yönetici unvanı", Category = "Tarih", Difficulty = "Orta" },
new Question { Word = "koloni", Clue = "Sömürge", Category = "Tarih", Difficulty = "Zor" },
new Question { Word = "moğol", Clue = "Cengiz Han'ın kurduğu imparatorluk", Category = "Tarih", Difficulty = "Zor" },
new Question { Word = "fransız", Clue = "1789 devrimiyle bilinen millet", Category = "Tarih", Difficulty = "Zor" },
new Question { Word = "sezar", Clue = "Roma diktatörü", Category = "Tarih", Difficulty = "Orta" },
new Question { Word = "viking", Clue = "Kuzeyli savaşçılar", Category = "Tarih", Difficulty = "Zor" },
new Question { Word = "pers", Clue = "Antik İran uygarlığı", Category = "Tarih", Difficulty = "Zor" },
new Question { Word = "lidya", Clue = "Parayı bulan uygarlık", Category = "Tarih", Difficulty = "Orta" },
new Question { Word = "hitler", Clue = "II. Dünya Savaşı lideri", Category = "Tarih", Difficulty = "Zor" },
new Question { Word = "napolyon", Clue = "Fransız komutan", Category = "Tarih", Difficulty = "Zor" },
new Question { Word = "truva", Clue = "Efsanevi antik kent", Category = "Tarih", Difficulty = "Orta" },
new Question { Word = "mısır", Clue = "Piramidleriyle ünlü uygarlık", Category = "Tarih", Difficulty = "Kolay" },
new Question { Word = "amazon", Clue = "Dünyanın en büyük nehri", Category = "Coğrafya", Difficulty = "Orta" },
new Question { Word = "everest", Clue = "En yüksek dağ", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "asya", Clue = "En büyük kıta", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "afrika", Clue = "Sahra Çölü bu kıtadadır", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "kutup", Clue = "Buzullarla kaplı bölge", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "alp", Clue = "Avrupa’nın en uzun dağ zinciri", Category = "Coğrafya", Difficulty = "Orta" },
new Question { Word = "and", Clue = "Güney Amerika sıradağları", Category = "Coğrafya", Difficulty = "Zor" },
new Question { Word = "ege", Clue = "Batı Anadolu denizi", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "karadeniz", Clue = "Türkiye’nin kuzeyinde yer alır", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "kapadokya", Clue = "Peri bacalarıyla ünlü bölge", Category = "Coğrafya", Difficulty = "Orta" },
new Question { Word = "balkan", Clue = "Güneydoğu Avrupa bölgesi", Category = "Coğrafya", Difficulty = "Orta" },
new Question { Word = "bozkır", Clue = "Ağaçsız otlak", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "delta", Clue = "Irmakların oluşturduğu ova", Category = "Coğrafya", Difficulty = "Orta" },
new Question { Word = "çöl", Clue = "Kurak ve susuz alan", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "vadi", Clue = "Dağlar arasında kalan çukur", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "sibirya", Clue = "Dondurucu soğuklarıyla bilinir", Category = "Coğrafya", Difficulty = "Zor" },
new Question { Word = "pasifik", Clue = "En büyük okyanus", Category = "Coğrafya", Difficulty = "Kolay" },
new Question { Word = "kafkas", Clue = "Karadeniz ile Hazar arasında yer alır", Category = "Coğrafya", Difficulty = "Zor" },
new Question { Word = "atlas", Clue = "Kuzeybatı Afrika dağları", Category = "Coğrafya", Difficulty = "Zor" },
new Question { Word = "anatolia", Clue = "Anadolu’nun İngilizcesi", Category = "Coğrafya", Difficulty = "Zor" },
new Question { Word = "integral", Clue = "Matematiksel işlem", Category = "Matematik", Difficulty = "Zor" },
new Question { Word = "karekök", Clue = "Bir sayının karesini veren işlem", Category = "Matematik", Difficulty = "Orta" },
new Question { Word = "geometri", Clue = "Şekillerle uğraşan matematik dalı", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "algebra", Clue = "Denklemlerle ilgili matematik dalı", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "pi", Clue = "Çemberin çevresinin çapına oranı", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "logaritma", Clue = "Üstel fonksiyonların tersi", Category = "Matematik", Difficulty = "Zor" },
new Question { Word = "denklem", Clue = "Eşitlik içeren matematiksel ifade", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "fonksiyon", Clue = "Girdi-çıktı ilişkisi", Category = "Matematik", Difficulty = "Orta" },
new Question { Word = "paralel", Clue = "Aynı doğrultuda kesişmeyen doğrular", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "açı", Clue = "İki doğrunun birleşme ölçüsü", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "çarpan", Clue = "Bir sayıyı bölen sayı", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "asal", Clue = "Yalnızca 1 ve kendisine bölünen sayı", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "çember", Clue = "Sabit uzaklıktaki noktalar kümesi", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "üslü", Clue = "Taban ve kuvvet içeren ifade", Category = "Matematik", Difficulty = "Orta" },
new Question { Word = "oran", Clue = "İki niceliğin karşılaştırılması", Category = "Matematik", Difficulty = "Kolay" },
new Question { Word = "matris", Clue = "Sayılar tablosu", Category = "Matematik", Difficulty = "Zor" },
new Question { Word = "türev", Clue = "Anlık değişim oranı", Category = "Matematik", Difficulty = "Zor" },
new Question { Word = "limit", Clue = "Yaklaşma değeri", Category = "Matematik", Difficulty = "Zor" },
new Question { Word = "hipotenüs", Clue = "Dik üçgende en uzun kenar", Category = "Matematik", Difficulty = "Orta" },
new Question { Word = "vektör", Clue = "Yönlü doğru parçası", Category = "Matematik", Difficulty = "Orta" },
        };

        private Question selectedQuestion;
        private string displayWord;
        private List<char> wrongGuesses = new List<char>();
        private int score = 100;
        private int imageIndex = 0;
        private System.Windows.Forms.Timer zamanlayici;
        private int remainingTime;

        public Form2()
        {
            InitializeComponent();
            SelectQuestion();

            displayWord = string.Join(" ", new string('_', selectedQuestion.Word.Length).ToCharArray());
            label1.Text = "İpucu: " + selectedQuestion.Clue;
            label2.Text = displayWord;
            label3.Text = "Yanlış tahminler: ";
            label4.Text = "Kelime uzunluğu: " + selectedQuestion.Word.Length;
            label5.Text = "Skor: 100";
            remainingTime = GameSettings.TimeLimit;

            label6.Text = remainingTime.ToString();
            label7.Text = $"Kategori: {GameSettings.SelectedCategory}, Seviye: {GameSettings.SelectedDifficulty}";

            zamanlayici = new System.Windows.Forms.Timer();
            zamanlayici.Interval = 1000;
            zamanlayici.Tick += Timer1_Tick;
            zamanlayici.Start();

            UpdateImage();
        }

        private void SelectQuestion()
        {
            var filtered = allQuestions.Where(q =>
                q.Category == GameSettings.SelectedCategory &&
                q.Difficulty == GameSettings.SelectedDifficulty).ToList();

            if (filtered.Count == 0) filtered = allQuestions;

            selectedQuestion = filtered[new Random().Next(filtered.Count)];
        }

        private void UpdateImage()
        {
            if (GameSettings.ImageTheme == "Adam")
            {
                if (imageIndex < 10)
                {
                    string imagePath = $"C:/Users/umutg/OneDrive/Masaüstü/klasor/hangman/man-0{imageIndex}.jpg";
                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                if (imageIndex == 10)
                {

                    string imagePath = $"C:/Users/umutg/OneDrive/Masaüstü/klasor/hangman/man-{imageIndex}.jpg";
                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
            if (GameSettings.ImageTheme == "Cicek")
            {
                if (imageIndex < 10)
                {
                    string imagePath = $"C:/Users/umutg/OneDrive/Masaüstü/klasor/papatya/ppt{10-imageIndex}.png";
                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                if (imageIndex == 10)
                {

                    string imagePath = $"C:/Users/umutg/OneDrive/Masaüstü/klasor/papatya/ppt{10-imageIndex}.png";
                    if (File.Exists(imagePath))
                    {
                        pictureBox1.Image = Image.FromFile(imagePath);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                char guess = textBox1.Text.ToLower()[0];
                textBox1.Clear();

                if (selectedQuestion.Word.Contains(guess))
                {
                    char[] chars = displayWord.Replace(" ", "").ToCharArray();
                    for (int i = 0; i < selectedQuestion.Word.Length; i++)
                    {
                        if (selectedQuestion.Word[i] == guess)
                            chars[i] = guess;
                    }
                    displayWord = string.Join(" ", chars);
                    label2.Text = displayWord;
                }
                else if (!wrongGuesses.Contains(guess))
                {
                    wrongGuesses.Add(guess);
                    label3.Text = "Wrong: " + string.Join(", ", wrongGuesses);
                    score -= 10;
                    label5.Text = "Skor: " + score;
                    imageIndex++;
                    UpdateImage();
                }

                if (displayWord.Replace(" ", "") == selectedQuestion.Word)
                {
                    this.BackColor = Color.Green;
                    MessageBox.Show("Kazandın, tebrikler!", "Oyun Bitti!");
                    zamanlayici.Stop();
                    ReturnMenu();
                }
                else if (score <= 0 || imageIndex >= 10)
                {
                    this.BackColor = Color.Red;
                    MessageBox.Show("Kaybettin!", "Oyun Bitti!");
                    ReturnMenu();
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label6.Text = remainingTime.ToString();
            if (remainingTime <= 0)
            {
                zamanlayici.Stop();
                MessageBox.Show("Süre doldu!", "Oyun Bitti");
                ReturnMenu();
            }
        }

        private void ReturnMenu()
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun kapatılıyor.", "Çıkış");
            ReturnMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }
    }
}
