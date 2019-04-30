using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace كسر_خوارزمية_قيصر
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Mod(int a, int n)
        {
            return a - (int)Math.Floor((double)a / n) * n;
        }

        string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        int key = 0;
        void Decrypt()
        {
            string CharUpper = textBoxCipher.Text.ToUpper();
            char[] Cipher = CharUpper.ToCharArray();
            for (int i = 0; i < Cipher.Length; i++)
            {
                if (alphabets.Contains(Cipher[i]))
                {
                    int CipherNumber = alphabets.IndexOf(Cipher[i]);
                    textBoxPlan.Text += alphabets[Mod(CipherNumber - key, 26)];
                }
                else
                {                    
                    textBoxPlan.Text += Cipher[i];
                }
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)  //زر فك التشفير
        {
            if (textBoxCipher.Text == "")
                MessageBox.Show("حقل النص المشفر فارغ");
            else
            {
                Decrypt();
                label1.Text = key + "/25";
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
           
            buttonPrev.Enabled = true;
            if (key < 25)
            {
                textBoxPlan.Clear();
                key++;
                Decrypt();
                label1.Text = key + "/25";
                if(key == 25)
                    buttonNext.Enabled = false;
            }
           
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
           
            buttonNext.Enabled = true;
            if (key > 0)
            {
                textBoxPlan.Clear();
                key--;
                Decrypt();
                label1.Text = key + "/25";
                if (key == 0)
                    buttonPrev.Enabled = false;
            }
        }
    }
}
