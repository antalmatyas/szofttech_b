using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G1_JPWQQK
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question>();
        private Question currentQuestion;
        private List<Question> inPractice = new List<Question>();
        private int nextQuestion = 7;
        Random rnd = new Random();
        private List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }
        private int getCorrectAnswer(string[] row)
        {
            if(row[3] == "I") return 1;
            else if(row[5] == "I") return 2;
            else return 3;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using(StreamReader sr = new StreamReader("./sources/data.csv", Encoding.Default))
                {
                    string bin = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string row = sr.ReadLine();
                        string[] rs = row.Split(';');
                        Question newQ = new Question();
                        newQ.questionText = rs[1];
                        newQ.answer1 = rs[2];
                        newQ.answer2 = rs[4];
                        newQ.answer3 = rs[6];
                        newQ.correctAnswer = getCorrectAnswer(rs);
                        newQ.imageName = rs[8];
                        newQ.answeredCorrectly = 0;
                        questions.Add(newQ);
                    }
                    sr.Close();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Hibás/nem található forrásfájl (csv)!");
                Environment.Exit(1);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Forrásfájl hibás (nem megfelelő számú oszlop/rossz elválasztás)");
                Environment.Exit(2);
            }

            for (int i = 0; i < 7; i++)
            {
                inPractice.Add(questions[i]);
            }

            currentQuestion = inPractice[0];
            buttons.Add(answerBtn1);
            buttons.Add(answerBtn2);
            buttons.Add(answerBtn3);
            resetButtons();
            loadQuestion();
        }
        private void loadQuestion()
        {
            int next = rnd.Next(7);
            currentQuestion = inPractice[next];
            this.questionTextLabel.Text = currentQuestion.questionText;
            this.buttons[0].Text = currentQuestion.answer1;
            this.buttons[1].Text = currentQuestion.answer2;
            this.buttons[2].Text = currentQuestion.answer3;
            if(currentQuestion.imageName == "")
            {
                this.questionPicture.Visible = false;
            }
            else
            {
                this.questionPicture.Visible = true;
                this.questionPicture.Load($"./images/{currentQuestion.imageName}");
            }
            if(currentQuestion.answer3 == "")
            {
                this.answerBtn3.Text = "-";
                this.answerBtn3.Enabled = false;
            }
            this.nextBtn.Enabled = false;
        }
        private void checkIfComplete()
        {
            if(currentQuestion.answeredCorrectly == 3)
            {
                inPractice.Remove(currentQuestion);
                if(nextQuestion < questions.Count)
                {
                    inPractice.Add(questions[nextQuestion]);
                    nextQuestion++;
                }
                if(inPractice.Count == 0)
                {
                    MessageBox.Show("Minden kérdést begyakoroltál!");
                    Environment.Exit(3);
                }
            }
        }
        private void resetButtons()
        {
            for (int i = 0; i < this.buttons.Count; i++)
            {
                this.buttons[i].Enabled = true;
                this.buttons[i].BackColor = SystemColors.GradientActiveCaption;
            }
        }

        private void lockButtons()
        {
            for (int i = 0; i < this.buttons.Count; i++)
            {
                this.buttons[i].Enabled = false;
            }
        }

        private void checkAnswer(int b)
        {
            lockButtons();
            if (b == currentQuestion.correctAnswer)
            {
                currentQuestion.answeredCorrectly++;
                this.buttons[b - 1].BackColor = Color.SeaGreen;
                checkIfComplete();
            }
            else
            {
                this.buttons[b-1].BackColor = Color.Red;
                this.buttons[currentQuestion.correctAnswer - 1].BackColor = Color.SeaGreen;
            }
            this.nextBtn.Enabled = true;
        }

        private void answerBtn1_Click(object sender, EventArgs e)
        {
            checkAnswer(1);
        }

        private void answerBtn2_Click(object sender, EventArgs e)
        {
            checkAnswer(2);
        }

        private void answerBtn3_Click(object sender, EventArgs e)
        {
            checkAnswer(3);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            resetButtons();
            loadQuestion();
        }
    }
}
