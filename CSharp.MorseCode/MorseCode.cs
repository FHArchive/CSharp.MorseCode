using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeWinForm
{
    public partial class MorseCode : Form
    {
        public MorseCode()
        {
            InitializeComponent();
        }

        private void run_Click(object sender, EventArgs e)
        {
            /*
             * Declare a string array set it to morse code 
             */
            string[] dictionary = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };


            /*
             * Get Input, and selected radio button 
             */
            string input = Input.Text;
            Boolean isEncode = true;

            if (Decode.Checked == true)
            {
                isEncode = false;
            }

            /*
             * Do encode or decode 
             */

            string outString = null;
            if (isEncode)
            {
                outString = encode(dictionary, input);
            }
            else
            {
                outString = decode(dictionary, input);
            }

            /*
             * Generate binary wave 
             */
            int[] binWave = null;
            if (isEncode)
            {
                binWave = genBinWav(dictionary, outString);
            }
            else
            {
                binWave = genBinWav(dictionary, input);
            }

            /*
             * Write result to output 
             */
            Output.Text = outString;


            /*
             *  Write bin wave to chart 
             */
            BinWav.Series[0]["PointWidth"] = "1";
            BinWav.Series[0].Points.DataBindY(binWave);
        }

        private string decode(string[] dictionary, string input)
        {
            
            string[] inputParts = input.Trim().Split();
            string outputString = null;
            foreach (string part in inputParts)
            {
                if (part == "/")
                {
                    outputString += " ";
                }
                else
                {
                    outputString += (char)(Array.IndexOf(dictionary, part) + 64);
                }
            }
            return outputString;
        }

        private string encode(string[] dictionary, string input)
        {
            input = input.ToUpper();
            string outputString = null;
            foreach (char character in input)
            {
                if ((int)character > 64 && (int)character < 64 + 27)
                {
                    outputString += dictionary[(int)character - 64] + " ";
                }
                else
                {
                    outputString += "/ ";
                }
            }


            return outputString;
        }

        private int[] genBinWav(string[] dictionary, string input)
        {
            /*
             * short mark, dot or "dit" (.): 1
             * longer mark, dash or "dah" (-): 111
             * intra-character gap (between the dots and dashes within a character): 0
             * short gap (between letters): 000
             * medium gap (between words): 0000000
             * 
             * combining (3) and (4) : 
             * 
             * short mark, dot or "dit" (.): 10
             * longer mark, dash or "dah" (-): 1110
             * short gap " "(between letters): 00
             * medium gap "/ " (between words): 0000
             */

            List<int> output = new List<int>();

            /*
             * Lazy error handling 
             */
             if (input == null)
            {
                input = " ";
            }


            foreach (char character in input)
            {
                if (character == '.')
                {
                    int[] temp = { 1, 0 };
                    output.AddRange(temp);
                }
                else if(character == '-')
                {
                    int[] temp = { 1, 1, 1, 0 };
                    output.AddRange(temp);
                }
                else if (character == ' ')
                {
                    int[] temp = { 0, 0 };
                    output.AddRange(temp);
                }
                else if (character == '/')
                {
                    int[] temp = { 0, 0, 0, 0 };
                    output.AddRange(temp);
                }
            }





            int[] ret = output.ToArray();
            return ret;
        }
    }
}
