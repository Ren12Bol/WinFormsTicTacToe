using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeInC_
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        static int count = 0;

        int XScore = 0;
        int OScore = 0;
        int Draws = 0;
        public bool WhosMove()
        {
            if (count == 0)
            {
                count++;
                return true;
            }
            else if (!(count%2 == 0))
            {
                count++;
                return false;
            }
            else
            {
                count++;
                return true;
            }
        }

        public string MakingMove()
        {
            if(WhosMove())
            {
                return "X";
            }
            else
            {
                return "O";
            }
        }

        public void WhosWon()
        {
            if((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A2.Enabled))
            {
                WhatPlayerIsIt(A2.Text);
                ResetGame();
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B2.Enabled))
            {
                WhatPlayerIsIt(B2.Text);
                ResetGame();
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C2.Enabled))
            {
                WhatPlayerIsIt(C2.Text);
                ResetGame();
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!B1.Enabled))
            {
                WhatPlayerIsIt(B1.Text);
                ResetGame();
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!B2.Enabled))
            {
                WhatPlayerIsIt(B2.Text);
                ResetGame();
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!B3.Enabled))
            {
                WhatPlayerIsIt(B3.Text);
                ResetGame();
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!B2.Enabled))
            {
                WhatPlayerIsIt(B2.Text);
                ResetGame();
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!B2.Enabled))
            {
                WhatPlayerIsIt(B2.Text);
                ResetGame();
            }
            else if ((!A1.Enabled) && (!A2.Enabled) && (!A3.Enabled) && (!B1.Enabled) && (!B2.Enabled) && (!B3.Enabled) && (!C1.Enabled) && (!C2.Enabled) && (!C3.Enabled))
            {
                Draws++;
                MessageBox.Show("Draw.");
                ResetGame();
            }
        }

        public void ResetGame()
        {
            A1.Text = "";
            A1.Enabled = true;
            A2.Text = "";
            A2.Enabled = true;
            A3.Text = "";
            A3.Enabled = true;
            B1.Text = "";
            B1.Enabled = true;
            B2.Text = "";
            B2.Enabled = true;
            B3.Text = "";
            B3.Enabled = true;
            C1.Text = "";
            C1.Enabled = true;
            C2.Text = "";
            C2.Enabled = true;
            C3.Text = "";
            C3.Enabled = true;

            SetScore();

            count = 0;
        }

        public void SetScore()
        {
            labelX.Text = XScore.ToString();
            labelO.Text = OScore.ToString();
            labelDraw.Text = Draws.ToString();
        }

        public void WhatPlayerIsIt(string player)
        {
            if (player == "X")
            {
                XScore++;
                MessageBox.Show("Player X won.");
            }
            else
            {
                OScore++;
                MessageBox.Show("Player O won.");
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void A1_Click(object sender, EventArgs e)
        {
            A1.Text = MakingMove();
            A1.Enabled = false;
            WhosWon();
        }

        private void A2_Click(object sender, EventArgs e)
        {
            A2.Text = MakingMove();
            A2.Enabled = false;
            WhosWon();
        }

        private void A3_Click(object sender, EventArgs e)
        {
            A3.Text = MakingMove();
            A3.Enabled = false;
            WhosWon();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            B1.Text = MakingMove();
            B1.Enabled = false;
            WhosWon();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            B2.Text = MakingMove();
            B2.Enabled = false;
            WhosWon();
        }

        private void B3_Click(object sender, EventArgs e)
        {

            B3.Text = MakingMove();
            B3.Enabled = false;
            WhosWon();
        }

        private void C1_Click(object sender, EventArgs e)
        {
            C1.Text = MakingMove();
            C1.Enabled = false;
            WhosWon();
        }

        private void C2_Click(object sender, EventArgs e)
        {
            C2.Text = MakingMove();
            C2.Enabled = false;
            WhosWon();
        }

        private void C3_Click(object sender, EventArgs e)
        {
            C3.Text = MakingMove();
            C3.Enabled = false;
            WhosWon();
        }

        private void ResetScoreButt_Click(object sender, EventArgs e)
        {
            XScore = 0;
            OScore = 0;
            Draws = 0;

            SetScore();
        }
    }
}
