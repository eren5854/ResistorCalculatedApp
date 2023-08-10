using System.Drawing.Imaging;
using System.Runtime.InteropServices.JavaScript;

namespace ResistorCalculatedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {

            Color b1 = btnBandOne.BackColor;
            Color b2 = btnBandTwo.BackColor;
            Color b3 = btnBandThree.BackColor;
            Color b4 = btnBandFour.BackColor;
            int band1 = xColor(b1);
            int band2 = yColor(b2);
            int band3 = zColor(b3);
            decimal band4 = tColor(b4);

            string b = Convert.ToString(band1) + Convert.ToString(band2);
            int v = Convert.ToInt32(b);
            int q = (int)Math.Pow(10, band3);
            int sonuc = v * q;
            lbValue.Text = Convert.ToString(sonuc) + "Ω " + "±" + band4 + "%";
        }
        private int xColor(Color x)
        {
            int a = 0;
            if (x == Color.Black)
            {
                a = 0;
            }
            if (x == Color.Brown)
            {
                a = 1;
            }
            if (x == Color.Red)
            {
                a = 2;
            }
            if (x == Color.Orange)
            {
                a = 3;
            }
            if (x == Color.Yellow)
            {
                a = 4;
            }
            if (x == Color.Green)
            {
                a = 5;
            }
            if (x == Color.Blue)
            {
                a = 6;
            }
            if (x == Color.Violet)
            {
                a = 7;
            }
            if (x == Color.Gray)
            {
                a = 8;
            }
            if (x == Color.White)
            {
                a = 9;
            }
            return a;
        }

        private int yColor(Color x)
        {
            int a = 0;
            if (x == Color.Black)
            {
                a = 0;
            }
            if (x == Color.Brown)
            {
                a = 1;
            }
            if (x == Color.Red)
            {
                a = 2;
            }
            if (x == Color.Orange)
            {
                a = 3;
            }
            if (x == Color.Yellow)
            {
                a = 4;
            }
            if (x == Color.Green)
            {
                a = 5;
            }
            if (x == Color.Blue)
            {
                a = 6;
            }
            if (x == Color.Violet)
            {
                a = 7;
            }
            if (x == Color.Gray)
            {
                a = 8;
            }
            if (x == Color.White)
            {
                a = 9;
            }
            return a;
        }

        private int zColor(Color x)
        {
            int a = 0;
            if (x == Color.Black)
            {
                a = 0;
            }
            if (x == Color.Brown)
            {
                a = 1;
            }
            if (x == Color.Red)
            {
                a = 2;
            }
            if (x == Color.Orange)
            {
                a = 3;
            }
            if (x == Color.Yellow)
            {
                a = 4;
            }
            if (x == Color.Green)
            {
                a = 5;
            }
            if (x == Color.Blue)
            {
                a = 6;
            }
            if (x == Color.Violet)
            {
                a = 7;
            }
            if (x == Color.Gray)
            {
                a = 8;
            }
            if (x == Color.White)
            {
                a = 9;
            }
            return a;
        }

        private decimal tColor(Color x)
        {
            decimal a = 0;
            if (x == Color.Brown)
            {
                a = 1;
            }
            if (x == Color.Red)
            {
                a = 2;
            }
            if (x == Color.Orange)
            {
                a = 3;
            }
            if (x == Color.Yellow)
            {
                a = 4;
            }
            if (x == Color.Green)
            {
                a = 0.5M;
            }
            if (x == Color.Blue)
            {
                a = 0.25M;
            }
            if (x == Color.Violet)
            {
                a = 0.1M;
            }
            if (x == Color.Gray)
            {
                a = 0.05M;
            }
            if (x == Color.Gold)
            {
                a = 5;
            }
            if (x == Color.Silver)
            {
                a = 10;
            }
            return a;

        }

        #region Color Buttons
        private void btnBlack_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Black;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Black;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Black;
            if (rbBandFour.Checked == true) MessageBox.Show("Band4 Siyah Renkte Olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnBrown_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Brown;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Brown;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Brown;
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Brown;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Red;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Red;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Red;
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Red;
        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Silver;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Yellow;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Yellow;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Yellow;
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Yellow;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Green;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Green;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Green;
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Blue;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Blue;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Blue;
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Blue;
        }

        private void btnViolet_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Violet;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Violet;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Violet;
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Yellow;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Gray;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Gray;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Gray;
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Gray;
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Yellow;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Yellow;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Yellow;
            if (rbBandFour.Checked == true) MessageBox.Show("Band4 Siyah Renkte Olamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnGold_Click(object sender, EventArgs e)
        {
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Gold;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            if (rbBandOne.Checked == true) btnBandOne.BackColor = Color.Orange;
            if (rbBandTwo.Checked == true) btnBandTwo.BackColor = Color.Orange;
            if (rbBandThree.Checked == true) btnBandThree.BackColor = Color.Orange;
            if (rbBandFour.Checked == true) btnBandFour.BackColor = Color.Orange;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm(); 
            imageForm.ShowDialog();
        }
        private void DisplayImage()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile("resim.png"); 
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom; 
            pictureBox.Dock = DockStyle.Fill; 

            Controls.Add(pictureBox); 
        }
    }
}