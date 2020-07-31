using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _03_Versleutelen
{
    public partial class Form1 : Form
    {
        static char[] ALPHABET = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        static int[] VALUES = { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3, 2, 1 };
        
        Dictionary<char, int> dictionary =
            new Dictionary<char, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;

            do { dictionary.Add(ALPHABET[i], VALUES[i % 13]); i++; } while (i < ALPHABET.Length);

            // textBox.Text = "As the moon changes her phases every seven days; this number influences all sublunary beings. -Shakespeare";
            // textBox.Text = "By its occult virtues tended to the accomplishment of all things, to be the dispenser of life and fountain of all its changes. -Hippocrates";
            textBox.Text = "With the child, it is the teeth that appear in the seventh month and he sheds them at seven years; at twice seven puberty begins, at three times seven all our mental and vital powers are developed, at four times seven he is in his full strength, at five times seven his passions are most developed";
        }

        private string septenary(string input)
        {         
            string output = "";
            char[] cinput = input.ToCharArray();

            foreach (char ch in cinput)
            {
                int i = ch;

                if (i > 96 && i < 123)
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

        private string deseptenary(string input)
        {
            string output = "";
            
            foreach (char chstr in input)
            {
                foreach (char numberchar in dictionary.Keys)
                {
                    if (dictionary[numberchar].ToString() == (chstr -48).ToString())
                    {
                        // add to possibilities array
                        Console.WriteLine($"add {numberchar} to the possibilities array at spot");
                    }
                }
                Console.WriteLine('\n');
            }
            Console.WriteLine(output);

            return output;
        }
        //Array.ForEach(str_array[0], element => Console.WriteLine("element = " + element.ToString()));

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