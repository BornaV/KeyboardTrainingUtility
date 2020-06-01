using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardTrainingUtility
{
    public partial class mainWindow : Form
    {
        public string tempSentanceInput;
        public string tempPressedKey;
        public int courrentPosition;
        public string tempStoredText = Clipboard.GetText();
        


        public mainWindow()
        {
            InitializeComponent();
            textBoxMain.Text = tempStoredText;
            textBoxInput.Focus();
            normalUnderline();
        }

        
        
        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e) //SeconderyTextBox used as reference
        {
            editTextColor(e);
        }
        private void textBoxMain_Enter(object sender, EventArgs e)
        {
            textBoxInput.Focus();
        }
        private void mainWindow_Enter(object sender, EventArgs e)
        {
            textBoxInput.Focus();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            setTextBoxText();
            textBoxInput.Focus();
        }

        
        void setTextBoxText()
        {
            totalReset();
            tempStoredText = Clipboard.GetText();
            textBoxMain.Text = tempStoredText;

        }
        void editTextColor(KeyPressEventArgs e)
        {
            if (textBoxInput.TextLength >= textBoxMain.TextLength) // outofbounds crash
            {
                string removeLastLetter = textBoxInput.Text;
                removeLastLetter = removeLastLetter.Remove(removeLastLetter.Length - 1, 1);
                textBoxInput.Text = removeLastLetter;
                textBoxInput.SelectionStart = textBoxInput.TextLength;
                textBoxInput.SelectionLength = 0;
                textBoxInput.Select();
                return;
            }
            if (textBoxInput.TextLength != courrentPosition)
            {
                courrentPosition = textBoxInput.TextLength;
            }


            normalUnderline(2, 'b');


            if (e.KeyChar == (char)Keys.Back) //pressing Backspace  //add esc key
            {
                
                if (courrentPosition > 0)
                {
                    letterColor(textBoxMain.TextLength - courrentPosition, 'b'); // need to test if bug proof
                    //textBoxMain.SelectionStart = courrentPosition;
                    //textBoxMain.SelectionLength = textBoxMain.TextLength - courrentPosition;
                    //textBoxMain.SelectionColor = Color.Black;
                    //textBoxMain.SelectionFont = new Font("Microsoft Sans Serif", 13, FontStyle.Regular); //make everithing in front of the selected 
                    normalUnderline();//make sure that the underline is 
                    courrentPosition--;
                }
                else
                {
                    letterColor(textBoxMain.TextLength - courrentPosition, 'b'); // need to test if bug proof
                    //textBoxMain.SelectionStart = courrentPosition;
                    //textBoxMain.SelectionLength = textBoxMain.TextLength - courrentPosition;
                    //textBoxMain.SelectionColor = Color.Black;
                    textBoxMain.SelectionFont = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
                    return;
                }
                return;
            }
            if (courrentPosition < textBoxMain.TextLength)
            {
                
                if (tempStoredText[courrentPosition] == e.KeyChar) //key press logic
                {
                    letterColor(1, 'g');
                    courrentPosition++;
                }
                else
                {
                    letterColor(1, 'r');
                    courrentPosition++;

                }

            }

        }
        void normalUnderline() //underlines the courrent selected letter, length is the amount of letters selected, color is what color the selected pice is;
        {
            textBoxMain.SelectionStart = courrentPosition;
            textBoxMain.SelectionLength = 1;
            textBoxMain.SelectionColor = Color.Black;
            textBoxMain.SelectionFont = new Font("Microsoft Sans Serif", 13, FontStyle.Underline);
        }
        void normalUnderline(int length, char color) //underlines the courrent selected letter, length is the amount of letters selected, color is what color the selected pice is;
        {
            textBoxMain.SelectionStart = courrentPosition;
            textBoxMain.SelectionLength = length;

            switch (color)
            {
                case 'r':
                    textBoxMain.SelectionColor = Color.Red;
                    break;

                case 'g':
                    textBoxMain.SelectionColor = Color.Green;
                    break;

                default:
                    textBoxMain.SelectionColor = Color.Black;
                    break;
            }
            textBoxMain.SelectionFont = new Font("Microsoft Sans Serif", 13, FontStyle.Underline);
        }
        void letterColor() //colors the selected letter depending on the input
        {
            textBoxMain.SelectionStart = courrentPosition;
            textBoxMain.SelectionLength = 1;
            textBoxMain.SelectionColor = Color.Black;
            textBoxMain.SelectionFont = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
        }
        void letterColor(int length, char color) //colors the selected letter depending on the input
        {
            textBoxMain.SelectionStart = courrentPosition;
            textBoxMain.SelectionLength = length;

            switch (color)
            {
                case 'r':
                    textBoxMain.SelectionColor = Color.Red;
                    break;

                case 'g':
                    textBoxMain.SelectionColor = Color.Green;
                    break;

                default:
                    textBoxMain.SelectionColor = Color.Black;
                    break;
            }
            textBoxMain.SelectionFont = new Font("Microsoft Sans Serif", 13, FontStyle.Regular);
        }
        void totalReset()
        {
            tempSentanceInput = "";
            tempPressedKey = "";
            courrentPosition = 0;
            tempStoredText = "";
            textBoxInput.Text = "";
        }

        
    }
}
