using System;
using System.Windows.Forms;

namespace mashroom
{
    public partial class MushroomIdentificationForm : Form
    {
        private int questionNumber;
        private bool hasRing;

        public MushroomIdentificationForm()
        {
            InitializeComponent();
            RestartIdentification();
        }

        private void CheckAnswer(bool answer)
        {
            questionNumber++;
            lblQuestionCount.Text = "Questions asked: " + questionNumber + " of 3";

            if (questionNumber == 1)
            {
                hasRing = answer;
                if (hasRing)
                {
                    lblQuestion.Text = "Does your mushroom grow in a forest?";
                }
                else
                {
                    lblQuestion.Text = "Does your mushroom have gills?";
                }
            }
            else if (questionNumber == 2)
            {
                if (hasRing)
                {
                    if (answer)
                    {
                        ShowResult("Amanite Tue-Mouches");
                    }
                    else
                    {
                        lblQuestion.Text = "Does your mushroom have a convex cap?";
                    }
                }
                else
                {
                    if (!answer)
                    {
                        ShowResult("Cepe de Bordeaux");
                    }
                    else
                    {
                        lblQuestion.Text = "Does your mushroom have a convex cap?";
                    }
                }
            }
            else if (questionNumber == 3)
            {
                if (hasRing)
                {
                    if (answer)
                    {
                        ShowResult("Agaric Jaunissant");
                    }
                    else
                    {
                        ShowResult("Coprin Chevelu");
                    }
                }
                else
                {
                    if (answer)
                    {
                        ShowResult("Pied Bleu");
                    }
                    else
                    {
                        ShowResult("Girolle");
                    }
                }
            }
        }

        private void ShowResult(string mushroomName)
        {
            lblResult.Text = "Your mushroom is: " + mushroomName;
            lblQuestion.Text = "Identification complete.";
            btnYes.Enabled = false;
            btnNo.Enabled = false;
        }

        private void RestartIdentification()
        {
            questionNumber = 0;
            hasRing = false;
            lblQuestion.Text = "Does your mushroom have a ring?";
            lblResult.Text = "Answer the questions to identify your mushroom.";
            lblQuestionCount.Text = "Questions asked: 0 of 3";
            btnYes.Enabled = true;
            btnNo.Enabled = true;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            CheckAnswer(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            CheckAnswer(false);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartIdentification();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
