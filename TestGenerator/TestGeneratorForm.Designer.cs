namespace TestGenerator
{
    partial class TestGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblQuastion = new System.Windows.Forms.Label();
            this.txtQuastion = new System.Windows.Forms.TextBox();
            this.lbQuastions = new System.Windows.Forms.ListBox();
            this.btnAddQuastion = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lbAnswers = new System.Windows.Forms.ListBox();
            this.txtMark = new System.Windows.Forms.NumericUpDown();
            this.lblMark = new System.Windows.Forms.Label();
            this.btnAddAnswer = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lbResultItems = new System.Windows.Forms.ListBox();
            this.btnAddResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarkFrom = new System.Windows.Forms.NumericUpDown();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkTo = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnDeleteAnswer = new System.Windows.Forms.Button();
            this.btnDeleteResult = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(76, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(747, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblQuastion
            // 
            this.lblQuastion.AutoSize = true;
            this.lblQuastion.Location = new System.Drawing.Point(13, 48);
            this.lblQuastion.Name = "lblQuastion";
            this.lblQuastion.Size = new System.Drawing.Size(60, 17);
            this.lblQuastion.TabIndex = 2;
            this.lblQuastion.Text = "Вопрос:";
            // 
            // txtQuastion
            // 
            this.txtQuastion.Location = new System.Drawing.Point(95, 45);
            this.txtQuastion.Name = "txtQuastion";
            this.txtQuastion.Size = new System.Drawing.Size(365, 22);
            this.txtQuastion.TabIndex = 3;
            // 
            // lbQuastions
            // 
            this.lbQuastions.FormattingEnabled = true;
            this.lbQuastions.ItemHeight = 16;
            this.lbQuastions.Location = new System.Drawing.Point(466, 48);
            this.lbQuastions.Name = "lbQuastions";
            this.lbQuastions.Size = new System.Drawing.Size(376, 180);
            this.lbQuastions.TabIndex = 4;
            this.lbQuastions.SelectedIndexChanged += new System.EventHandler(this.lbQuastions_SelectedIndexChanged);
            // 
            // btnAddQuastion
            // 
            this.btnAddQuastion.Location = new System.Drawing.Point(283, 73);
            this.btnAddQuastion.Name = "btnAddQuastion";
            this.btnAddQuastion.Size = new System.Drawing.Size(177, 29);
            this.btnAddQuastion.TabIndex = 5;
            this.btnAddQuastion.Text = "Добавить вопрос";
            this.btnAddQuastion.UseVisualStyleBackColor = true;
            this.btnAddQuastion.Click += new System.EventHandler(this.btnAddQuastion_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(95, 234);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(365, 22);
            this.txtAnswer.TabIndex = 7;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(13, 237);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(52, 17);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Text = "Ответ:";
            // 
            // lbAnswers
            // 
            this.lbAnswers.FormattingEnabled = true;
            this.lbAnswers.ItemHeight = 16;
            this.lbAnswers.Location = new System.Drawing.Point(466, 234);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(376, 180);
            this.lbAnswers.TabIndex = 8;
            // 
            // txtMark
            // 
            this.txtMark.Location = new System.Drawing.Point(95, 262);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(96, 22);
            this.txtMark.TabIndex = 9;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.Location = new System.Drawing.Point(13, 267);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(37, 17);
            this.lblMark.TabIndex = 10;
            this.lblMark.Text = "Бал:";
            // 
            // btnAddAnswer
            // 
            this.btnAddAnswer.Location = new System.Drawing.Point(283, 287);
            this.btnAddAnswer.Name = "btnAddAnswer";
            this.btnAddAnswer.Size = new System.Drawing.Size(177, 42);
            this.btnAddAnswer.TabIndex = 11;
            this.btnAddAnswer.Text = "Добавить ответ к выбраному вопросу";
            this.btnAddAnswer.UseVisualStyleBackColor = true;
            this.btnAddAnswer.Click += new System.EventHandler(this.btnAddAnswer_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(16, 606);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(679, 22);
            this.txtPath.TabIndex = 12;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(701, 606);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(28, 23);
            this.btnOpenDialog.TabIndex = 13;
            this.btnOpenDialog.Text = "...";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(735, 606);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "json|*.json";
            // 
            // lbResultItems
            // 
            this.lbResultItems.FormattingEnabled = true;
            this.lbResultItems.ItemHeight = 16;
            this.lbResultItems.Location = new System.Drawing.Point(466, 420);
            this.lbResultItems.Name = "lbResultItems";
            this.lbResultItems.Size = new System.Drawing.Size(376, 180);
            this.lbResultItems.TabIndex = 15;
            // 
            // btnAddResult
            // 
            this.btnAddResult.Location = new System.Drawing.Point(283, 505);
            this.btnAddResult.Name = "btnAddResult";
            this.btnAddResult.Size = new System.Drawing.Size(177, 42);
            this.btnAddResult.TabIndex = 20;
            this.btnAddResult.Text = "Добавить результат";
            this.btnAddResult.UseVisualStyleBackColor = true;
            this.btnAddResult.Click += new System.EventHandler(this.btnAddResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Бал от:";
            // 
            // txtMarkFrom
            // 
            this.txtMarkFrom.Location = new System.Drawing.Point(95, 448);
            this.txtMarkFrom.Name = "txtMarkFrom";
            this.txtMarkFrom.Size = new System.Drawing.Size(96, 22);
            this.txtMarkFrom.TabIndex = 18;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(95, 420);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(365, 22);
            this.txtResult.TabIndex = 17;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 423);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(80, 17);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "До:";
            // 
            // txtMarkTo
            // 
            this.txtMarkTo.Location = new System.Drawing.Point(234, 448);
            this.txtMarkTo.Name = "txtMarkTo";
            this.txtMarkTo.Size = new System.Drawing.Size(96, 22);
            this.txtMarkTo.TabIndex = 21;
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(283, 108);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(177, 29);
            this.btnDeleteQuestion.TabIndex = 23;
            this.btnDeleteQuestion.Text = "Удалить";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnDeleteAnswer
            // 
            this.btnDeleteAnswer.Location = new System.Drawing.Point(283, 335);
            this.btnDeleteAnswer.Name = "btnDeleteAnswer";
            this.btnDeleteAnswer.Size = new System.Drawing.Size(177, 29);
            this.btnDeleteAnswer.TabIndex = 24;
            this.btnDeleteAnswer.Text = "Удалить";
            this.btnDeleteAnswer.UseVisualStyleBackColor = true;
            this.btnDeleteAnswer.Click += new System.EventHandler(this.btnDeleteAnswer_Click);
            // 
            // btnDeleteResult
            // 
            this.btnDeleteResult.Location = new System.Drawing.Point(283, 553);
            this.btnDeleteResult.Name = "btnDeleteResult";
            this.btnDeleteResult.Size = new System.Drawing.Size(177, 29);
            this.btnDeleteResult.TabIndex = 25;
            this.btnDeleteResult.Text = "Удалить";
            this.btnDeleteResult.UseVisualStyleBackColor = true;
            this.btnDeleteResult.Click += new System.EventHandler(this.btnDeleteResult_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(95, 476);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(331, 22);
            this.txtImagePath.TabIndex = 27;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(13, 479);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(75, 17);
            this.lblImage.TabIndex = 26;
            this.lblImage.Text = "Картинка:";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(432, 476);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(28, 23);
            this.btnOpenFileDialog.TabIndex = 28;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // TestGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 636);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnDeleteResult);
            this.Controls.Add(this.btnDeleteAnswer);
            this.Controls.Add(this.btnDeleteQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarkTo);
            this.Controls.Add(this.btnAddResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarkFrom);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lbResultItems);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenDialog);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnAddAnswer);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.lbAnswers);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnAddQuastion);
            this.Controls.Add(this.lbQuastions);
            this.Controls.Add(this.txtQuastion);
            this.Controls.Add(this.lblQuastion);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "TestGeneratorForm";
            this.Text = "Создание теста";
            ((System.ComponentModel.ISupportInitialize)(this.txtMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblQuastion;
        private System.Windows.Forms.TextBox txtQuastion;
        private System.Windows.Forms.ListBox lbQuastions;
        private System.Windows.Forms.Button btnAddQuastion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.ListBox lbAnswers;
        private System.Windows.Forms.NumericUpDown txtMark;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Button btnAddAnswer;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ListBox lbResultItems;
        private System.Windows.Forms.Button btnAddResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtMarkFrom;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtMarkTo;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Button btnDeleteAnswer;
        private System.Windows.Forms.Button btnDeleteResult;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

