using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace project_1
{
    public partial class QuizWithRadioButton : System.Web.UI.Page
    {
        // These dictionaries will be stored in session to persist between postbacks
        protected Dictionary<int, string> Questions
        {
            get
            {
                if (Session["Questions"] == null)
                    Session["Questions"] = new Dictionary<int, string>();
                return (Dictionary<int, string>)Session["Questions"];
            }
            set { Session["Questions"] = value; }
        }

        protected Dictionary<int, string> Answers
        {
            get
            {
                if (Session["Answers"] == null)
                    Session["Answers"] = new Dictionary<int, string>();
                return (Dictionary<int, string>)Session["Answers"];
            }
            set { Session["Answers"] = value; }
        }

        protected Dictionary<int, string[]> Options
        {
            get
            {
                if (Session["Options"] == null)
                    Session["Options"] = new Dictionary<int, string[]>();
                return (Dictionary<int, string[]>)Session["Options"];
            }
            set { Session["Options"] = value; }
        }

        protected void InitializeQuestions()
        {
            Questions.Clear();
            Answers.Clear();
            Options.Clear();

            Questions.Add(1, "Sample question 1");
            Questions.Add(2, "Sample question 2");
            Questions.Add(3, "Sample question 3");
            Questions.Add(4, "Sample question 4");
            Questions.Add(5, "Sample question 5");

            Options[1] = new string[]
            {
                "Red",
                "Blue",
                "Green",
                "Orange"
            };
            Options[2] = new string[] {
                "Option 1",
                "Option 2",
                "Option 3",
                "Option 4"
            };
            Options[3] = new string[] {
                "Option 1",
                "Option 2",
                "Option 3",
                "Option 4"
            };
            Options[4] = new string[] {
                "Option 1",
                "Option 2",
                "Option 3",
                "Option 4"
            };
            Options[5] = new string[] {
                "Option 1",
                "Option 2",
                "Option 3",
                "Option 4"
            };

            Answers.Add(1, "Red");
            Answers.Add(2, "Option 3");
            Answers.Add(3, "Option 1");
            Answers.Add(4, "Option 1");
            Answers.Add(5, "Option 4");
        }

        protected void LoadQuestion()
        {
            int currentQuestion = (int)ViewState["currentQuestion"];

            try
            {
                QuestionLabel.Text = Questions[currentQuestion];
                RadioButtonList1.Items.Clear();
                foreach (var option in Options[currentQuestion])
                {
                    RadioButtonList1.Items.Add(new ListItem(option, option));
                }
            }
            catch (KeyNotFoundException)
            {
                LblScore.Text = $"Score: {ViewState["marks"]}";
                QuestionLabel.Text = "Quiz completed!";
                RadioButtonList1.Visible = false;
                Submit.Visible = false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializeQuestions();
                ViewState["currentQuestion"] = 1;
                ViewState["marks"] = 0;
                LoadQuestion();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            int currentQuestion = (int)ViewState["currentQuestion"];
            int marks = (int)ViewState["marks"];

            if (Answers.ContainsKey(currentQuestion) &&
                RadioButtonList1.SelectedValue == Answers[currentQuestion])
            {
                marks++;
            }

            ViewState["marks"] = marks;
            ViewState["currentQuestion"] = currentQuestion + 1;
            LoadQuestion();
        }
    }
}