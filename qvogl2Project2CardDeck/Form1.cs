using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qvogl2Project2CardDeck
{
    public partial class Form1 : Form
    {

        List<String> Cards = new List<string>(new String[] { "2c", "2d", "2s", "2h",
                                                                "3c", "3d", "3s", "3h",
                                                                "4c", "4d", "4s", "4h",
                                                                "5c", "5d", "5s", "5h",
                                                                "6c", "6d", "6s", "6h",
                                                                "7c", "7d", "7s", "7h",
                                                                "8c", "8d", "8s", "8h",
                                                                "9c", "9d", "9s", "9h",
                                                                "10c", "10d", "10s", "10h",
                                                                "jc", "jd", "js", "jh",
                                                                "qc", "qd", "qs", "qh",
                                                                "kc", "kd", "ks", "kh",
                                                                "ac", "ad", "as", "ah" });
        public Form1()
        {
            InitializeComponent();
        }

        private void cardPictureBox_Click(object sender, EventArgs e)
        {

            SoundPlayer shuffleSound = new SoundPlayer(Properties.Resources.shuffle);
            shuffleSound.Play();

            //Console.WriteLine(Controls.Count.ToString());
            int count = 0;

            List<Control> removal = new List<Control>();
            foreach (Control child in Controls)
            {
                //Console.WriteLine(child.Name);
                count++;

                if (child is PictureBox && !child.Name.Equals("cardPictureBox"))
                    removal.Add(child);

            }

            foreach(Control child in removal)
            {
                child.Dispose();
            }
            //Console.WriteLine(count + " " + Controls.Count.ToString());


            List<String> drawnCards = new List<String>();

            int numOfCards = 0;
            try
            {
                numOfCards = Convert.ToInt32(drawAmount.Text);
            } catch (Exception ex)
            {
                MessageBox.Show("Please input 0-52 cards.");
            }

            if (numOfCards > 52 || numOfCards < 0)
            {
                MessageBox.Show("Invalid entry. Please select 0-52 cards.");
                return;
            }
            
            int drawn = 0;
            Random random = new Random();
            String cardSelected;
            int x = 0;
            int y = 110;
            while (drawn < numOfCards)
            {
                PictureBox pictureBox1 = new PictureBox();

                if (drawn % 13 == 0)
                {
                    y += 45;
                    x = 12;
                }
                drawn++;
                

                cardSelected = Cards[random.Next(0, Cards.Count)];
                while (drawnCards.Contains(cardSelected))
                {
                    cardSelected = Cards[random.Next(0, Cards.Count)];
                }
                drawnCards.Add(cardSelected);
                //Console.WriteLine(cardSelected);
                

                switch (cardSelected)
                {
                    case "2c": pictureBox1.Image = Properties.Resources._2_of_clubs; break;
                    case "2d": pictureBox1.Image = Properties.Resources._2_of_diamonds; break;
                    case "2s": pictureBox1.Image = Properties.Resources._2_of_spades; break;
                    case "2h": pictureBox1.Image = Properties.Resources._2_of_hearts; break;
                    case "3c": pictureBox1.Image = Properties.Resources._3_of_clubs; break;
                    case "3d": pictureBox1.Image = Properties.Resources._3_of_diamonds; break;
                    case "3s": pictureBox1.Image = Properties.Resources._3_of_spades; break;
                    case "3h": pictureBox1.Image = Properties.Resources._3_of_hearts; break;
                    case "4c": pictureBox1.Image = Properties.Resources._4_of_clubs; break;
                    case "4d": pictureBox1.Image = Properties.Resources._4_of_diamonds; break;
                    case "4s": pictureBox1.Image = Properties.Resources._4_of_spades; break;
                    case "4h": pictureBox1.Image = Properties.Resources._4_of_hearts; break;
                    case "5c": pictureBox1.Image = Properties.Resources._5_of_clubs; break;
                    case "5d": pictureBox1.Image = Properties.Resources._5_of_diamonds; break;
                    case "5s": pictureBox1.Image = Properties.Resources._5_of_spades; break;
                    case "5h": pictureBox1.Image = Properties.Resources._5_of_hearts; break;
                    case "6c": pictureBox1.Image = Properties.Resources._6_of_clubs; break;
                    case "6d": pictureBox1.Image = Properties.Resources._6_of_diamonds; break;
                    case "6s": pictureBox1.Image = Properties.Resources._6_of_spades; break;
                    case "6h": pictureBox1.Image = Properties.Resources._6_of_hearts; break;
                    case "7c": pictureBox1.Image = Properties.Resources._7_of_clubs; break;
                    case "7d": pictureBox1.Image = Properties.Resources._7_of_diamonds; break;
                    case "7s": pictureBox1.Image = Properties.Resources._7_of_spades; break;
                    case "7h": pictureBox1.Image = Properties.Resources._7_of_hearts; break;
                    case "8c": pictureBox1.Image = Properties.Resources._8_of_clubs; break;
                    case "8d": pictureBox1.Image = Properties.Resources._8_of_diamonds; break;
                    case "8s": pictureBox1.Image = Properties.Resources._8_of_spades; break;
                    case "8h": pictureBox1.Image = Properties.Resources._8_of_hearts; break;
                    case "9c": pictureBox1.Image = Properties.Resources._9_of_clubs; break;
                    case "9d": pictureBox1.Image = Properties.Resources._9_of_diamonds; break;
                    case "9s": pictureBox1.Image = Properties.Resources._9_of_spades; break;
                    case "9h": pictureBox1.Image = Properties.Resources._9_of_hearts; break;
                    case "10c": pictureBox1.Image = Properties.Resources._10_of_clubs; break;
                    case "10d": pictureBox1.Image = Properties.Resources._10_of_diamonds; break;
                    case "10s": pictureBox1.Image = Properties.Resources._10_of_spades; break;
                    case "10h": pictureBox1.Image = Properties.Resources._10_of_hearts; break;
                    case "jc": pictureBox1.Image = Properties.Resources.jack_of_clubs2; break;
                    case "jd": pictureBox1.Image = Properties.Resources.jack_of_diamonds2; break;
                    case "js": pictureBox1.Image = Properties.Resources.jack_of_spades2; break;
                    case "jh": pictureBox1.Image = Properties.Resources.jack_of_hearts2; break;
                    case "qc": pictureBox1.Image = Properties.Resources.queen_of_clubs2; break;
                    case "qd": pictureBox1.Image = Properties.Resources.queen_of_diamonds2; break;
                    case "qs": pictureBox1.Image = Properties.Resources.queen_of_spades2; break;
                    case "qh": pictureBox1.Image = Properties.Resources.queen_of_hearts2; break;
                    case "kc": pictureBox1.Image = Properties.Resources.king_of_clubs2; break;
                    case "kd": pictureBox1.Image = Properties.Resources.king_of_diamonds2; break;
                    case "ks": pictureBox1.Image = Properties.Resources.king_of_spades2; break;
                    case "kh": pictureBox1.Image = Properties.Resources.king_of_hearts2; break;
                    case "ac": pictureBox1.Image = Properties.Resources.ace_of_clubs; break;
                    case "ad": pictureBox1.Image = Properties.Resources.ace_of_diamonds; break;
                    case "as": pictureBox1.Image = Properties.Resources.ace_of_spades; break;
                    case "ah": pictureBox1.Image = Properties.Resources.ace_of_hearts; break;
                    
                }

                pictureBox1.Name = "Card" + drawn;
                pictureBox1.Size = new Size(72, 100);
                pictureBox1.Location = new Point(x, y);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                this.Controls.Add(pictureBox1);

                pictureBox1.BringToFront();

                x += 12;

            }

        }

    }
}
