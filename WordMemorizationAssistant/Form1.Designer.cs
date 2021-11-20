
namespace WordMemorizationAssistant
{
    partial class FormWordMemorizationAssistant
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
            this.labelWordForTranslate = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLearnWords = new System.Windows.Forms.TabPage();
            this.buttonCheckNexWord = new System.Windows.Forms.Button();
            this.labelRightAnswer = new System.Windows.Forms.Label();
            this.labelUserAnswer = new System.Windows.Forms.Label();
            this.tabPageAddWords = new System.Windows.Forms.TabPage();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.textBoxInputTranslateWord = new System.Windows.Forms.TextBox();
            this.labelInputTranslateWord = new System.Windows.Forms.Label();
            this.textBoxInputEnglishWord = new System.Windows.Forms.TextBox();
            this.labelInputEnglishWord = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageLearnWords.SuspendLayout();
            this.tabPageAddWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUserAnswer.Location = new System.Drawing.Point(8, 114);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(237, 46);
            this.textBoxUserAnswer.TabIndex = 0;
            // 
            // labelWordForTranslate
            // 
            this.labelWordForTranslate.AutoSize = true;
            this.labelWordForTranslate.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWordForTranslate.Location = new System.Drawing.Point(8, 14);
            this.labelWordForTranslate.Name = "labelWordForTranslate";
            this.labelWordForTranslate.Size = new System.Drawing.Size(240, 40);
            this.labelWordForTranslate.TabIndex = 1;
            this.labelWordForTranslate.Text = "WordForTranslate";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLearnWords);
            this.tabControl1.Controls.Add(this.tabPageAddWords);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLearnWords
            // 
            this.tabPageLearnWords.Controls.Add(this.buttonCheckNexWord);
            this.tabPageLearnWords.Controls.Add(this.labelRightAnswer);
            this.tabPageLearnWords.Controls.Add(this.labelUserAnswer);
            this.tabPageLearnWords.Controls.Add(this.labelWordForTranslate);
            this.tabPageLearnWords.Controls.Add(this.textBoxUserAnswer);
            this.tabPageLearnWords.Location = new System.Drawing.Point(4, 24);
            this.tabPageLearnWords.Name = "tabPageLearnWords";
            this.tabPageLearnWords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLearnWords.Size = new System.Drawing.Size(564, 422);
            this.tabPageLearnWords.TabIndex = 0;
            this.tabPageLearnWords.Text = "tabPageLearnWords";
            this.tabPageLearnWords.UseVisualStyleBackColor = true;
            // 
            // buttonCheckNexWord
            // 
            this.buttonCheckNexWord.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckNexWord.Location = new System.Drawing.Point(8, 312);
            this.buttonCheckNexWord.Name = "buttonCheckNexWord";
            this.buttonCheckNexWord.Size = new System.Drawing.Size(325, 102);
            this.buttonCheckNexWord.TabIndex = 5;
            this.buttonCheckNexWord.Text = "buttonCheckNexWord";
            this.buttonCheckNexWord.UseVisualStyleBackColor = true;
            this.buttonCheckNexWord.Click += new System.EventHandler(this.buttonCheckNexWord_Click);
            // 
            // labelRightAnswer
            // 
            this.labelRightAnswer.AutoSize = true;
            this.labelRightAnswer.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRightAnswer.Location = new System.Drawing.Point(8, 187);
            this.labelRightAnswer.Name = "labelRightAnswer";
            this.labelRightAnswer.Size = new System.Drawing.Size(177, 40);
            this.labelRightAnswer.TabIndex = 4;
            this.labelRightAnswer.Text = "RightAnswer";
            // 
            // labelUserAnswer
            // 
            this.labelUserAnswer.AutoSize = true;
            this.labelUserAnswer.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserAnswer.Location = new System.Drawing.Point(8, 71);
            this.labelUserAnswer.Name = "labelUserAnswer";
            this.labelUserAnswer.Size = new System.Drawing.Size(167, 40);
            this.labelUserAnswer.TabIndex = 2;
            this.labelUserAnswer.Text = "UserAnswer";
            // 
            // tabPageAddWords
            // 
            this.tabPageAddWords.Controls.Add(this.buttonAddWord);
            this.tabPageAddWords.Controls.Add(this.textBoxInputTranslateWord);
            this.tabPageAddWords.Controls.Add(this.labelInputTranslateWord);
            this.tabPageAddWords.Controls.Add(this.textBoxInputEnglishWord);
            this.tabPageAddWords.Controls.Add(this.labelInputEnglishWord);
            this.tabPageAddWords.Location = new System.Drawing.Point(4, 24);
            this.tabPageAddWords.Name = "tabPageAddWords";
            this.tabPageAddWords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddWords.Size = new System.Drawing.Size(852, 422);
            this.tabPageAddWords.TabIndex = 1;
            this.tabPageAddWords.Text = "tabPageAddWords";
            this.tabPageAddWords.UseVisualStyleBackColor = true;
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddWord.Location = new System.Drawing.Point(8, 294);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(325, 102);
            this.buttonAddWord.TabIndex = 6;
            this.buttonAddWord.Text = "buttonAddWord";
            this.buttonAddWord.UseVisualStyleBackColor = true;
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // textBoxInputTranslateWord
            // 
            this.textBoxInputTranslateWord.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInputTranslateWord.Location = new System.Drawing.Point(8, 169);
            this.textBoxInputTranslateWord.Name = "textBoxInputTranslateWord";
            this.textBoxInputTranslateWord.Size = new System.Drawing.Size(404, 46);
            this.textBoxInputTranslateWord.TabIndex = 3;
            // 
            // labelInputTranslateWord
            // 
            this.labelInputTranslateWord.AutoSize = true;
            this.labelInputTranslateWord.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInputTranslateWord.Location = new System.Drawing.Point(8, 126);
            this.labelInputTranslateWord.Name = "labelInputTranslateWord";
            this.labelInputTranslateWord.Size = new System.Drawing.Size(327, 40);
            this.labelInputTranslateWord.TabIndex = 2;
            this.labelInputTranslateWord.Text = "labelInputTranslateWord";
            // 
            // textBoxInputEnglishWord
            // 
            this.textBoxInputEnglishWord.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInputEnglishWord.Location = new System.Drawing.Point(8, 57);
            this.textBoxInputEnglishWord.Name = "textBoxInputEnglishWord";
            this.textBoxInputEnglishWord.Size = new System.Drawing.Size(404, 46);
            this.textBoxInputEnglishWord.TabIndex = 1;
            // 
            // labelInputEnglishWord
            // 
            this.labelInputEnglishWord.AutoSize = true;
            this.labelInputEnglishWord.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInputEnglishWord.Location = new System.Drawing.Point(8, 14);
            this.labelInputEnglishWord.Name = "labelInputEnglishWord";
            this.labelInputEnglishWord.Size = new System.Drawing.Size(305, 40);
            this.labelInputEnglishWord.TabIndex = 0;
            this.labelInputEnglishWord.Text = "labelInputEnglishWord";
            // 
            // FormWordMemorizationAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormWordMemorizationAssistant";
            this.Text = "Word memorization assistant";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLearnWords.ResumeLayout(false);
            this.tabPageLearnWords.PerformLayout();
            this.tabPageAddWords.ResumeLayout(false);
            this.tabPageAddWords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserAnswer;
        private System.Windows.Forms.Label labelWordForTranslate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLearnWords;
        private System.Windows.Forms.Label labelRightAnswer;
        private System.Windows.Forms.Label labelUserAnswer;
        private System.Windows.Forms.TabPage tabPageAddWords;
        private System.Windows.Forms.Button buttonCheckNexWord;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.TextBox textBoxInputTranslateWord;
        private System.Windows.Forms.Label labelInputTranslateWord;
        private System.Windows.Forms.TextBox textBoxInputEnglishWord;
        private System.Windows.Forms.Label labelInputEnglishWord;
    }
}

