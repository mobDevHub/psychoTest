using Model;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace TestGenerator
{
    public partial class TestGeneratorForm : Form
    {
        public Test _test;

        public TestGeneratorForm()
        {
            InitializeComponent();
        }

        private void CreateTestIfNotExist()
        {
            if (_test == null)
                _test = new Test { Name = txtName.Text };
        }

        private void btnAddQuastion_Click(object sender, EventArgs e)
        {
            CreateTestIfNotExist();

            var quastion = new Question
            {
                Text = txtQuastion.Text
            };

            _test.Questions.Add(quastion);
            lbQuastions.Items.Add(quastion.Text);
            txtQuastion.Text = string.Empty;
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            if (_test == null)
                return;

            var currentQuestion = _test.Questions[lbQuastions.SelectedIndex];

            var answer = new Answer
            {
                Text = txtAnswer.Text,
                Mark = (int)txtMark.Value
            };

            currentQuestion.Answers.Add(answer);
            lbAnswers.Items.Add(answer);

            txtAnswer.Text = string.Empty;
            txtMark.Value = 0;
        }

        private void lbQuastions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentQuestion = _test.Questions[lbQuastions.SelectedIndex];

            lbAnswers.Items.Clear();
            currentQuestion.Answers.ForEach(x => lbAnswers.Items.Add(x));
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            CreateTestIfNotExist();

            var resultItem = new ResultItem
            {
                Text = txtResult.Text,
                MarkFrom = (int)txtMarkFrom.Value,
                MarkTo = (int)txtMarkTo.Value,
            };

            lbResultItems.Items.Add(resultItem);
            _test.ResultItems.Add(resultItem);

            txtMarkFrom.Value = 0;
            txtMarkTo.Value = 0;
            txtResult.Text = string.Empty;
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (_test == null)
                return;

            _test.Questions.RemoveAt(lbQuastions.SelectedIndex);
            lbQuastions.Items.RemoveAt(lbQuastions.SelectedIndex);
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (_test == null)
                return;

            var currentQuestion = _test.Questions[lbAnswers.SelectedIndex];
            currentQuestion.Answers.RemoveAt(lbAnswers.SelectedIndex);
            lbAnswers.Items.RemoveAt(lbAnswers.SelectedIndex);
        }

        private void btnDeleteResult_Click(object sender, EventArgs e)
        {
            if (_test == null)
                return;

            _test.ResultItems.RemoveAt(lbResultItems.SelectedIndex);
            lbResultItems.Items.RemoveAt(lbResultItems.SelectedIndex);
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = saveFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var serialisedTest = JsonConvert.SerializeObject(_test);
            File.WriteAllText(txtPath.Text, serialisedTest);

            MessageBox.Show(this, "Файл сохранен");
        }
    }
}
