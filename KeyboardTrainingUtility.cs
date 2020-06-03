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
        public string lastGenerator;
        public string tempStoredText;
        


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
            lastGenerator = "Clipboard";
            setTextBoxText();
            textBoxInput.Focus();
        }
        private void buttonRadnomText_Click(object sender, EventArgs e)
        {
            lastGenerator = "Text";
            ranSentance();
            textBoxInput.Focus();
        }
        private void buttonRadnomLetter_Click(object sender, EventArgs e)
        {
            lastGenerator = "Letter";
            ranLetter(50, true);
            textBoxInput.Focus();
        }


        void setTextBoxText()
        {
            totalReset();
            tempStoredText = Clipboard.GetText();
            textBoxMain.Text = tempStoredText;

        }
        void editTextColor(KeyPressEventArgs e) //what is pressed logic
        
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (courrentPosition == textBoxMain.TextLength)
                {
                    switch (lastGenerator)
                    {
                        case "Text":
                            ranSentance();
                            break;
                        case "Letter":
                            ranLetter(50, true);
                            break;
                        default:
                            break;
                    }
                    return;
                }
                else
                {
                    removeLastLetter();
                    return;
                }
                
            }// checks if the sequenc e is complete and adds another
            if (textBoxInput.TextLength >= textBoxMain.TextLength) // outofbounds crash
            {
                removeLastLetter();
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
        void ranLetter(int length, bool includeUpper) //random scharacter generator
        {
            totalReset();
            char[] letter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            char[] letterUpper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Random rndLetter = new Random();
            Random rndLetterUpper = new Random();
            Random gen = new Random();
            int prob = gen.Next(100);
            if (includeUpper == true)
            {

                
                for (int i = 0; i < length; i++)
                {
                    if (gen.Next(100) < 25) // determens the percantage of the upper letters (100) < 40 40 persent that the letter is upper case
                    {
                        int randomLetterUpper = rndLetterUpper.Next(letterUpper.Length);
                        tempStoredText = tempStoredText + $"{letterUpper[randomLetterUpper]}";

                    }
                    else
                    {
                        int randomLetter = rndLetter.Next(letter.Length);
                        tempStoredText = tempStoredText + $"{letter[randomLetter]}";
                    }
                }
            } else
            {
                for (int i = 0; i < length; i++)
                {

                    int randomLetter = rndLetter.Next(letter.Length);
                    tempStoredText = tempStoredText + $"{letter[randomLetter]}";
                }
            }



            textBoxMain.Text = tempStoredText;
        }
        void ranSentance()
        {
            totalReset();
            string[] article = { "the", "a", "one", "some", "any", }; //add a bunch more :)
            string[] noun = { "boy", "girl", "dog", "town", "car", };
            string[] verb = { "drove", "jumped", "ran", "walked", "skipped", };
            string[] preposition = { "to", "from", "over", "under", "on", };

            Random rndArticle = new Random();
            Random rndNoun = new Random();
            Random rndVerb = new Random();
            Random rndPreposition = new Random();
            Random rndLayout = new Random();

            int randomArticle = rndArticle.Next(article.Length);
            int randomNoun = rndNoun.Next(noun.Length);
            int randomVerb = rndVerb.Next(verb.Length);
            int randoPreposition = rndPreposition.Next(preposition.Length);
            int randomLayout = rndLayout.Next(3); //amount switch case cases

            switch (randomLayout)
            {
                case 1:
                    tempStoredText = $"{article[randomArticle]} {noun[randomNoun]} {verb[randomVerb]} {preposition[randoPreposition]} {noun[randomNoun]}.";
                    break;
                case 2:
                    tempStoredText = $"{article[randomArticle]} {noun[randomNoun]} {verb[randomVerb]} {preposition[randoPreposition]} {article[randomArticle]} {noun[randomNoun]}.";
                    break;
                //case 3:
                //    tempStoredText = $"{article[randomArticle]} {noun[randomNoun]}.";
                //    break;
                //case 4:
                //    tempStoredText = $"{article[randomArticle]} {noun[randomNoun]}.";
                //    break;
                default:
                    tempStoredText = $"{article[randomArticle]} {noun[randomNoun]}.";
                    break;
            }

            //Console.WriteLine("{0} {1}", article[randomarticle], noun[randomnoun]);
            //tempStoredText = $"{article[randomArticle]} {noun[randomNoun]}.";
            textBoxMain.Text = tempStoredText;

        }
        void removeLastLetter()
        {
            string removeLastLetter = textBoxInput.Text;
            removeLastLetter = removeLastLetter.Remove(removeLastLetter.Length - 1, 1);
            textBoxInput.Text = removeLastLetter;
            textBoxInput.SelectionStart = textBoxInput.TextLength;
            textBoxInput.SelectionLength = 0;
            textBoxInput.Select();
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
