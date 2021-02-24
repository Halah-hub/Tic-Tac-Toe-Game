using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Tic_tac_toe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int pluseone;


        void Enable_falls()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void Score() 
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" )
            {
                button1.BackColor = System.Drawing.Color.PowderBlue;
                button2.BackColor = System.Drawing.Color.PowderBlue;
                button3.BackColor = System.Drawing.Color.PowderBlue;

                MessageBox.Show("The winner is plyer X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(pluseone +1 );
                Enable_falls();
            }

            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = System.Drawing.Color.Pink;
                button4.BackColor = System.Drawing.Color.Pink;
                button7.BackColor = System.Drawing.Color.Pink;

                MessageBox.Show("The winner is plyer X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }


            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = System.Drawing.Color.Crimson;
                button5.BackColor = System.Drawing.Color.Crimson;
                button9.BackColor = System.Drawing.Color.Crimson;

                MessageBox.Show("The winner is plyer X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }


            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button2.BackColor = System.Drawing.Color.SlateBlue;
                button5.BackColor = System.Drawing.Color.SlateBlue;
                button8.BackColor = System.Drawing.Color.SlateBlue;

                MessageBox.Show("The winner is plyer X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }

            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button3.BackColor = System.Drawing.Color.CadetBlue;
                button5.BackColor = System.Drawing.Color.CadetBlue;
                button7.BackColor = System.Drawing.Color.CadetBlue;

                MessageBox.Show("The winner is plyer X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }


            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button3.BackColor = System.Drawing.Color.Violet;
                button6.BackColor = System.Drawing.Color.Violet;
                button9.BackColor = System.Drawing.Color.Violet;

                MessageBox.Show("The winner is plyer X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = System.Drawing.Color.DarkSlateBlue;
                button5.BackColor = System.Drawing.Color.DarkSlateBlue;
                button6.BackColor = System.Drawing.Color.DarkSlateBlue;

                MessageBox.Show("The winner is plyer X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = System.Drawing.Color.Azure;
                button8.BackColor = System.Drawing.Color.Azure;
                button9.BackColor = System.Drawing.Color.Azure;

                MessageBox.Show("The winner is plyer X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }



            //*******************************************************************




            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.AliceBlue;
                button2.BackColor = System.Drawing.Color.AliceBlue;
                button3.BackColor = System.Drawing.Color.AliceBlue;

                MessageBox.Show("The winner is plyer O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }



            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.LemonChiffon;
                button4.BackColor = System.Drawing.Color.LemonChiffon;
                button7.BackColor = System.Drawing.Color.LemonChiffon;

                MessageBox.Show("The winner is plyer O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }


            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                button1.BackColor = System.Drawing.Color.BlueViolet;
                button5.BackColor = System.Drawing.Color.BlueViolet;
                button9.BackColor = System.Drawing.Color.BlueViolet;

                MessageBox.Show("The winner is plyer O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }


            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                button3.BackColor = System.Drawing.Color.NavajoWhite;
                button5.BackColor = System.Drawing.Color.NavajoWhite;
                button7.BackColor = System.Drawing.Color.NavajoWhite;

                MessageBox.Show("The winner is plyer O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }


            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                button2.BackColor = System.Drawing.Color.SandyBrown;
                button5.BackColor = System.Drawing.Color.SandyBrown;
                button8.BackColor = System.Drawing.Color.SandyBrown;

                MessageBox.Show("The winner is plyer O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }


            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                button3.BackColor = System.Drawing.Color.SeaGreen;
                button6.BackColor = System.Drawing.Color.SeaGreen;
                button9.BackColor = System.Drawing.Color.SeaGreen;

                MessageBox.Show("The winner is plyer O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }


            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                button4.BackColor = System.Drawing.Color.Azure;
                button5.BackColor = System.Drawing.Color.Azure;
                button6.BackColor = System.Drawing.Color.Azure;

                MessageBox.Show("The winner is plyer O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                button7.BackColor = System.Drawing.Color.DarkBlue;
                button8.BackColor = System.Drawing.Color.DarkBlue;
                button9.BackColor = System.Drawing.Color.DarkBlue;

                MessageBox.Show("The winner is plyer O", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pluseone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(pluseone + 1);
                Enable_falls();
            }

        }


        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;

            }
            else
            {
                button3.Text = "O";
                checker = false;
            }

            Score();
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;

            }
            else
            {
                button4.Text = "O";
                checker = false;
            }

            Score();
            button4.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false) 
            {
                button1.Text = "X";
                checker = true;

            }
            else
            {
                button1.Text = "O";
                checker = false;
            }

            Score();
            button1.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;

            }
            else
            {
                button6.Text = "O";
                checker = false;
            }

            Score();
            button6.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;

            }
            else
            {
                button2.Text = "O";
                checker = false;
            }

            Score();
            button2.Enabled = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;

            }
            else
            {
                button5.Text = "O";
                checker = false;
            }

            Score();
            button5.Enabled = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;

            }
            else
            {
                button8.Text = "O";
                checker = false;
            }

            Score();
            button8.Enabled = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;

            }
            else
            {
                button7.Text = "O";
                checker = false;
            }

            Score();
            button7.Enabled = false;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;

            }
            else
            {
                button9.Text = "O";
                checker = false;
            }

            Score();
            button9.Enabled = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;


                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;

                label4.Text = "0";
                label5.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Tic Toc toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", " Tic Toc toe",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }

            }
            catch ( Exception ex) 
            {
                MessageBox.Show( ex.Message , " Tic Toc toe" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;


                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                button14.Enabled = true;

                button1.BackColor = Color.WhiteSmoke;
                button2.BackColor = Color.WhiteSmoke;
                button3.BackColor = Color.WhiteSmoke;
                button4.BackColor = Color.WhiteSmoke;
                button5.BackColor = Color.WhiteSmoke;
                button6.BackColor = Color.WhiteSmoke;
                button7.BackColor = Color.WhiteSmoke;
                button8.BackColor = Color.WhiteSmoke;
                button9.BackColor = Color.WhiteSmoke;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Tic Toc toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
