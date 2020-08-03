using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Windows.Forms;

namespace _03_Versleutelen
{
    public partial class Form1 : Form
    {
        static char[] ALPHABET = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        static char[] TEBAHPLA = "abcdefghijklmnopqrstuvwxyz".Reverse().ToArray();
        bool flippedAlpha = false;

        static byte[] VALUES = { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1 };

        string keystring = "";
        
        Dictionary<char, byte> dictionary =
            new Dictionary<char, byte>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            byte i = 0;
            do { dictionary.Add(ALPHABET[i], VALUES[i % VALUES.Length]); i++; } while (i < ALPHABET.Length);

            textBox.Text = "With the child, it is the teeth that appear in the seventh month and he sheds them at seven years; at twice seven puberty begins, at three times seven all our mental and vital powers are developed, at four times seven he is in his full strength, at five times seven his passions are most developed -Hippocrates";
        }

        private string septenary(string input)
        {         
            string output = "";
            char[] cinput = input.ToLower().ToCharArray();

            char[] keyValues = "11111112222223333332444444".ToCharArray();
            keystring = "";

            int x = 0;
            foreach (char ch in cinput)
            {
                switch (ch)
                {
                    case char i when (ch > 96 && ch < 123):
                        keystring += keyValues[ch - 97];
                        output += dictionary[ch];
                        break;
                    case ' ': if (x != 0 && cinput[x - 1] != ' ') { keystring += '0'; output += '0'; }; break;
                    case '.': goto default;
                    case ',': goto default;
                    case ';': goto default;
                    case char i when (ch > 32 && ch < 48): goto default;
                    default: if (extraBox.Checked == true) { keystring += ch; output += ch; break; } else keystring += '0'; output += '0'; break;
                }
                x++;
            }
            if (keyBox.Checked == true)
                keyTextBox.Text = keystring;

            return output;
        }

        private string deseptenary(string input)
        {
            string output = "";
            char[][] parray = new char[input.Length][];

            int x = 0;
            foreach (char chstr in input)
            {
                switch (chstr)
                {
                    case '0': if (x != 0 && input[x -1] != '0') { output += ' '; }; break;
                    case '.': goto default;
                    case ',': goto default;
                    case ';': goto default;
                    case char i when (i > 48 && i < 56):
                        if (i == 55) { parray[x] = new char[2]; }
                        else            parray[x] = new char[4];

                        int y = 0;
                        foreach (char numberchar in dictionary.Keys)
                        {
                            if (dictionary[numberchar].ToString() == (chstr - 48).ToString())
                            {
                                parray[x][y] = numberchar;
                                y++;
                            }
                        }
                        
                        if (keyTextBox.Text.Length != input.Length)
                        {
                            y = 0;
                            output += $" |_ ";
                            foreach (char value in parray[x]) { output += parray[x][y]; y++; };
                            output += " _| ";
                        }
                        else
                            try { output += parray[x][keyTextBox.Text[x] - 49];
                            } catch { output += 'X'; }
                        break;

                    default: if (extraBox.Checked == true) { parray[x] = new char[1]; parray[x][0] = chstr; output += chstr; break; }  break;
                }
                x++;
            }

            return output;
        }

        private void btn_to_Click(object sender, EventArgs e)
        {
            textBox.Text = septenary(textBox.Text);
        }
        private void btn_from_Click(object sender, EventArgs e)
        {
            textBox.Text = deseptenary(textBox.Text);
        }

        private void btn_revfrom_Click(object sender, EventArgs e)
        {
            flippedAlpha = !flippedAlpha;
                        
            dictionary.Clear();

            byte i = 0;
            /*            
            do { dictionary.Add(ALPHABET[tempsize], VALUES[i % VALUES.Length]); i++;
            } while (i < ALPHABET.Length);
            */
            
            if (flippedAlpha) {
                do { dictionary.Add(ALPHABET[ALPHABET.Length - 1 - i], VALUES[i % VALUES.Length]); i++; }
                while (i < TEBAHPLA.Length);
                btn_revfrom.BackColor = Color.FromName("Lime");
            } else {
                do { dictionary.Add(ALPHABET[i], VALUES[i % VALUES.Length]); i++; }
                while (i < ALPHABET.Length);
                btn_revfrom.BackColor = Color.FromName("ControlLight");
            };
        }

        private void rst_Btn_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            keyTextBox.Text = "";
            keystring = "";
        }
    }
}