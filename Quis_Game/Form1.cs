using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quis_Game
{
    public partial class Form1 : Form
    {

        //Quiz Game Variables

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;



        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                // work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz is Complete" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + " %" + Environment.NewLine +
                    "Click Ok to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);





            }


            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.iphone;

                    lblQuestion.Text = "What year was the very first model of the iPhone released?";

                    button1.Text = "2007";
                    button2.Text = "2009";
                    button3.Text = "2011";
                    button4.Text = "2006";

                    correctAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.DC;

                    lblQuestion.Text = "What does DC stand for?";

                    button1.Text = "Dunder Comics";
                    button2.Text = "Dumb Comics";
                    button3.Text = "Detective Comics";
                    button4.Text = "Doom Comics";

                    correctAnswer = 3;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.cards;

                    lblQuestion.Text = "How many cards are in a standard deck?";

                    button1.Text = "50";
                    button2.Text = "48";
                    button3.Text = "55";
                    button4.Text = "52";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.Doggie;

                    lblQuestion.Text = "What is the tallest breed of dog in the world?";

                    button1.Text = "Great Dane";
                    button2.Text = "Staffordshire Bull Terrier";
                    button3.Text = "English Mastiff";
                    button4.Text = "Great Pyrenees";

                    correctAnswer = 1;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.country;

                    lblQuestion.Text = "What is the smallest country in the world?";

                    button1.Text = "Vatican City";
                    button2.Text = "Monaco";
                    button3.Text = "Nauru";
                    button4.Text = "Tuvalu";

                    correctAnswer = 1;

                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.usa_colored_regions_map;

                    lblQuestion.Text = "What was the first state?";

                    button1.Text = "New York";
                    button2.Text = "Delaware";
                    button3.Text = "Pennsylvania";
                    button4.Text = "Maine";

                    correctAnswer = 2;

                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.rock;

                    lblQuestion.Text = "What’s the hardest rock?";

                    button1.Text = "Boron";
                    button2.Text = "Titanium Carbide";
                    button3.Text = "Diamond";
                    button4.Text = "Dwayne Johnson";

                    correctAnswer = 3;

                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.country;

                    lblQuestion.Text = "Which country was the Caesar salad invented in?";

                    button1.Text = "Italy";
                    button2.Text = "Mexico";
                    button3.Text = "USA";
                    button4.Text = "China";

                    correctAnswer = 2;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.vender;

                    lblQuestion.Text = "What country has the most vending machines per capita?";

                    button1.Text = "USA";
                    button2.Text = "England";
                    button3.Text = "Japan";
                    button4.Text = "France";

                    correctAnswer = 3;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.tank;

                    lblQuestion.Text = "Tanks were used in battle for the first time in which conflict?";

                    button1.Text = "Spanish-American War";
                    button2.Text = "World War I";
                    button3.Text = "World War II";
                    button4.Text = "Persian Gulf War";

                    correctAnswer = 2;

                    break;
            }





        }

    }
}
