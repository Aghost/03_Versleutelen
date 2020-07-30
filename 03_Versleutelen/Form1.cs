using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Versleutelen
{
    public partial class Form1 : Form
    {
        static char[] ALPHABET = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        static uint[] VALUES = { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1 };
        
        string thecipher = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // textBox.Text = "As the moon changes her phases every seven days; this number influences all sublunary beings. -Shakespeare";
            // textBox.Text = "By its occult virtues tended to the accomplishment of all things, to be the dispenser of life and fountain of all its changes. -Hippocrates";
            textBox.Text = "With the child, it is the teeth that appear in the seventh month and he sheds them at seven years; at twice seven puberty begins, at three times seven all our mental and vital powers are developed, at four times seven he is in his full strength, at five times seven his passions are most developed";
        }

        private string septenary(string input)
        {
            var dictionary = new Dictionary<char, uint>();
            uint i = 0;
            do { dictionary.Add(ALPHABET[i], VALUES[i % 13]); i++; } while (i < ALPHABET.Length);

            foreach (var key in dictionary)
            {
                thecipher += key.Value.ToString();
            }
            Console.WriteLine(thecipher);

            string output = "";
            char[] cinput = input.ToCharArray();

            foreach (char ch in cinput)
            {
                int it = (int)ch;
                if (it > 96 && it < 123)
                {
                    output += dictionary[ch];
                }
                else if (ch == ' ')
                {
                    output += ' ';
                }
                else
                {
                    output += ch;
                }
            }
            Console.WriteLine(output);
            return output;
        }
        
        private string deseptenary(string str, int key = 0)
        {
            string output = "";

            var dictionary = new Dictionary<char, uint>();
            uint i = 0;
            do { dictionary.Add(ALPHABET[i], VALUES[i % 13]); i++; } while (i < ALPHABET.Length);

            //i = 0;
            //var dictionary2 = new Dictionary<uint, char>();
            //do { dictionary2.Add(VALUES[i % 13], ALPHABET[i]); i++; } while (i < ALPHABET.Length);

            /*
            new char[][] allLetters = { [] }
            
            foreach (char charIndex in str)
                str
            allLetters.Append(new char[] { });    
            */

            string[] possibilities = {};
            // foreach 'int'-value ch in dictionary2.keys
            uint temp = 0;

            foreach (char ch in str)
            {
                //foreach (dictionary2.TryGetValue(possibilities[ch]) in )
                //foreach (char ch2 in dictionary2.TryGetValue())
                dictionary.TryGetValue(ch, out temp);
                output += "char: " + ch + "\ttemp: " + temp + "\n";
            }
            return output;
        }

        private void btn_to_Click(object sender, EventArgs e)
        {
            textBox.Text = septenary(textBox.Text.ToLower());
        }

        private void btn_from_Click(object sender, EventArgs e)
        {
            textBox.Text = deseptenary(textBox.Text.ToLower());
        }
    }
}
