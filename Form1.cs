using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace kółko_i_krzyżyk
{
    public partial class btn_nowa_gra : Form 
    {
        public btn_nowa_gra()
        {
            InitializeComponent();
        }

      

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




        int ruch = 0;
        bool graczO = true;

        private void button1_Click(object sender, EventArgs e)
        {
            Nowa_Gra();
            wynik_o.Text = "0";
            wynik_x.Text = "0";
            lbl_ruch.Text = "O";
            graczO = true;
        }

        private void Nowa_Gra()
        {
            ruch = 0;

           Button[] all = new Button[9];
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;
            foreach(Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
                b.BackColor = Color.White;
            }


        }



        public void Sprawdzenie()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                Wygrana();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                Wygrana();
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                Wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                Wygrana();
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                Wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                Wygrana();
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                Wygrana();
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                Wygrana();
            }
            else if (ruch == 9)
            {
                Color red = Color.Red;
                btn1.BackColor = red;
                btn2.BackColor = red;
                btn3.BackColor = red;
                btn4.BackColor = red;
                btn5.BackColor = red;
                btn6.BackColor = red;
                btn7.BackColor = red;
                btn8.BackColor = red;
                btn9.BackColor = red;
                MessageBox.Show("       Remis", "Koniec gry", MessageBoxButtons.OK);
                Nowa_Gra();
            }
        }

      

        private void Wygrana()
        {
            MessageBox.Show("       Wygrywa "+ (graczO ? "O":"X"), "Koniec gry", MessageBoxButtons.OK);
            if (graczO)
                wynik_o.Text = ((int.Parse(wynik_o.Text)) + 1).ToString();
            else
                wynik_x.Text = ((int.Parse(wynik_x.Text)) + 1).ToString();
            Nowa_Gra();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = graczO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdzenie();
            }
            graczO = !graczO;
            lbl_ruch.Text = graczO ? "O" : "X";
        }

        private void btn_nowa_gra_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string[] kolorki = new string[6] { "DarkGray","PaleGoldenrod", "GreenYellow", "Yellow", "Gainsboro", "Olive" };

            Random losowe_kolorki = new Random();
            int loosowe = losowe_kolorki.Next(0, 5);

            BackColor = Color.FromName(kolorki[loosowe]);

            
             
        }
    }
}
