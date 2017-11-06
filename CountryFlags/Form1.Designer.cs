namespace CountryFlags
{
  partial class Form1
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
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.buttonSubmitAnswer = new System.Windows.Forms.Button();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.buttonNewQuestion = new System.Windows.Forms.Button();
      this.quizImage = new System.Windows.Forms.PictureBox();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.countryCode = new System.Windows.Forms.Label();
      this.labelSelectCountry = new System.Windows.Forms.Label();
      this.countrySelect = new System.Windows.Forms.ListBox();
      this.flagImage = new System.Windows.Forms.PictureBox();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.quizImage)).BeginInit();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.flagImage)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.buttonSubmitAnswer);
      this.tabPage2.Controls.Add(this.radioButton4);
      this.tabPage2.Controls.Add(this.radioButton3);
      this.tabPage2.Controls.Add(this.radioButton2);
      this.tabPage2.Controls.Add(this.radioButton1);
      this.tabPage2.Controls.Add(this.buttonNewQuestion);
      this.tabPage2.Controls.Add(this.quizImage);
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(846, 487);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Quiz";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // buttonSubmitAnswer
      // 
      this.buttonSubmitAnswer.Location = new System.Drawing.Point(380, 436);
      this.buttonSubmitAnswer.Name = "buttonSubmitAnswer";
      this.buttonSubmitAnswer.Size = new System.Drawing.Size(75, 23);
      this.buttonSubmitAnswer.TabIndex = 6;
      this.buttonSubmitAnswer.Text = "Submit";
      this.buttonSubmitAnswer.UseVisualStyleBackColor = true;
      this.buttonSubmitAnswer.Click += new System.EventHandler(this.buttonSubmitAnswer_Click);
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Location = new System.Drawing.Point(345, 398);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(17, 16);
      this.radioButton4.TabIndex = 5;
      this.radioButton4.TabStop = true;
      this.radioButton4.UseVisualStyleBackColor = true;
      this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(345, 371);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(17, 16);
      this.radioButton3.TabIndex = 4;
      this.radioButton3.TabStop = true;
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(345, 344);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(17, 16);
      this.radioButton2.TabIndex = 3;
      this.radioButton2.TabStop = true;
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(345, 317);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(17, 16);
      this.radioButton1.TabIndex = 2;
      this.radioButton1.TabStop = true;
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // buttonNewQuestion
      // 
      this.buttonNewQuestion.Location = new System.Drawing.Point(359, 26);
      this.buttonNewQuestion.Name = "buttonNewQuestion";
      this.buttonNewQuestion.Size = new System.Drawing.Size(117, 23);
      this.buttonNewQuestion.TabIndex = 1;
      this.buttonNewQuestion.Text = "New Question";
      this.buttonNewQuestion.UseVisualStyleBackColor = true;
      this.buttonNewQuestion.Click += new System.EventHandler(this.buttonNewQuestion_Click);
      // 
      // quizImage
      // 
      this.quizImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.quizImage.Location = new System.Drawing.Point(227, 64);
      this.quizImage.Name = "quizImage";
      this.quizImage.Size = new System.Drawing.Size(380, 242);
      this.quizImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.quizImage.TabIndex = 0;
      this.quizImage.TabStop = false;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.countryCode);
      this.tabPage1.Controls.Add(this.labelSelectCountry);
      this.tabPage1.Controls.Add(this.countrySelect);
      this.tabPage1.Controls.Add(this.flagImage);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(846, 487);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Browse";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // countryCode
      // 
      this.countryCode.AutoSize = true;
      this.countryCode.Location = new System.Drawing.Point(323, 308);
      this.countryCode.Name = "countryCode";
      this.countryCode.Size = new System.Drawing.Size(102, 17);
      this.countryCode.TabIndex = 4;
      this.countryCode.Text = "[Country Code]";
      // 
      // labelSelectCountry
      // 
      this.labelSelectCountry.AutoSize = true;
      this.labelSelectCountry.Location = new System.Drawing.Point(9, 6);
      this.labelSelectCountry.Name = "labelSelectCountry";
      this.labelSelectCountry.Size = new System.Drawing.Size(104, 17);
      this.labelSelectCountry.TabIndex = 3;
      this.labelSelectCountry.Text = "Select Country:";
      // 
      // countrySelect
      // 
      this.countrySelect.FormattingEnabled = true;
      this.countrySelect.ItemHeight = 16;
      this.countrySelect.Location = new System.Drawing.Point(9, 26);
      this.countrySelect.Name = "countrySelect";
      this.countrySelect.Size = new System.Drawing.Size(240, 356);
      this.countrySelect.TabIndex = 2;
      this.countrySelect.SelectedIndexChanged += new System.EventHandler(this.countrySelect_SelectedIndexChanged);
      // 
      // flagImage
      // 
      this.flagImage.Location = new System.Drawing.Point(323, 6);
      this.flagImage.Name = "flagImage";
      this.flagImage.Size = new System.Drawing.Size(517, 272);
      this.flagImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.flagImage.TabIndex = 0;
      this.flagImage.TabStop = false;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(0, 1);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(854, 516);
      this.tabControl1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(855, 518);
      this.Controls.Add(this.tabControl1);
      this.Name = "Form1";
      this.Text = "Flag Explorer";
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.quizImage)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.flagImage)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.Label labelSelectCountry;
    private System.Windows.Forms.ListBox countrySelect;
    private System.Windows.Forms.PictureBox flagImage;
    private System.Windows.Forms.Label countryCode;
    private System.Windows.Forms.Button buttonSubmitAnswer;
    private System.Windows.Forms.RadioButton radioButton4;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.Button buttonNewQuestion;
    private System.Windows.Forms.PictureBox quizImage;
  }
}

