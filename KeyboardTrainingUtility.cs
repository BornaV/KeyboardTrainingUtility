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
            ranLetter(textBoxAmount.Text);
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
                            ranLetter(textBoxAmount.Text);
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
        void ranLetter(string STLength) //random scharacter generator
        {
            int length = Convert.ToInt32(STLength);
            totalReset();
            Data rndSentanceData = new Data();

            //char[] rndSentanceData.letter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            //char[] rndSentanceData.letterUpper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Random rndLetter = new Random();
            Random rndLetterUpper = new Random();
            Random gen = new Random();
            int prob = gen.Next(100);
            for (int i = 0; i < length; i++)
                {
                    if (gen.Next(100) < trackBarUpperCase.Value) // determens the percantage of the upper letters (100) < 40 40 persent that the letter is upper case
                    {
                        int randomLetterUpper = rndLetterUpper.Next(rndSentanceData.letterUpper.Length);
                        tempStoredText = tempStoredText + $"{rndSentanceData.letterUpper[randomLetterUpper]}";

                    }
                    else
                    {
                        int randomLetter = rndLetter.Next(rndSentanceData.letter.Length);
                        tempStoredText = tempStoredText + $"{rndSentanceData.letter[randomLetter]}";
                    }
                }
            
            textBoxMain.Text = tempStoredText;
        }
        void randomizeSamples()
        {
            Data data = new Data();

        }
        void ranSentance()
        {
            totalReset();



            //string[] data.article = { "the", "a", "one", "some", "any", }; //add a bunch more :)
            //string[] data.noun = { "boy", "girl", "dog", "town", "car", };
            //string[] data.verb = { "drove", "jumped", "ran", "walked", "skipped", };
            //string[] data.preposition = { "to", "from", "over", "under", "on", };


            Data data = new Data();
            Random rndArticle = new Random();
            Random rndNoun = new Random();
            Random rndVerb = new Random();
            Random rndPreposition = new Random();
            Random rndLayout = new Random();

            int randomArticle = rndArticle.Next(data.article.Length);
            int randomNoun = rndNoun.Next(data.noun.Length);
            int randomVerb = rndVerb.Next(data.verb.Length);
            int randoPreposition = rndPreposition.Next(data.preposition.Length);
            int randomLayout = rndLayout.Next(3); //amount switch case cases

            switch (randomLayout)
            {
                case 1:
                    tempStoredText = tempStoredText + $"{data.article[randomArticle]} {data.noun[randomNoun]} {data.verb[randomVerb]} {data.preposition[randoPreposition]} ";
                    randomNoun = rndNoun.Next(data.noun.Length);
                    tempStoredText = tempStoredText + $"{data.noun[randomNoun]}.";
                    //tempStoredText = $"{data.article[randomArticle]} {data.noun[randomNoun]} {data.verb[randomVerb]} {data.preposition[randoPreposition]} {data.noun[randomNoun]}.";
                    break;
                case 2:
                    tempStoredText = $"{data.article[randomArticle]} {data.noun[randomNoun]} {data.verb[randomVerb]} {data.preposition[randoPreposition]} ";
                    randomArticle = rndArticle.Next(data.article.Length);
                    randomNoun = rndNoun.Next(data.noun.Length);
                    tempStoredText = $"{data.article[randomArticle]} {data.noun[randomNoun]}.";
                    //tempStoredText = $"{data.article[randomArticle]} {data.noun[randomNoun]} {data.verb[randomVerb]} {data.preposition[randoPreposition]} {data.article[randomArticle]} {data.noun[randomNoun]}.";
                    break;
                //case 3:
                //    tempStoredText = $"{article[randomArticle]} {noun[randomNoun]}.";
                //    break;
                //case 4:
                //    tempStoredText = $"{article[randomArticle]} {noun[randomNoun]}.";
                //    break;
                default:
                    tempStoredText = $"{data.article[randomArticle]} {data.noun[randomNoun]}.";
                    break;
            }

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

        private void trackBarUpperCase_ValueChanged(object sender, EventArgs e)
        {
            labelTrackBarValue.Text = $"Upper Case Amount: {Convert.ToString(trackBarUpperCase.Value)} %";
        }
    }
}
