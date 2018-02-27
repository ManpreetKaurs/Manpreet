namespace Personality_Tester_Application
{
    partial class PersonalityQuestions
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.radionButtonLeast = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.radioButtonSomewhat = new System.Windows.Forms.RadioButton();
            this.radioButtonMost = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblQuestion.Location = new System.Drawing.Point(12, 48);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(440, 28);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Following are the three options in this test:";
            // 
            // radionButtonLeast
            // 
            this.radionButtonLeast.AutoSize = true;
            this.radionButtonLeast.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionButtonLeast.ForeColor = System.Drawing.Color.Black;
            this.radionButtonLeast.Location = new System.Drawing.Point(12, 108);
            this.radionButtonLeast.Name = "radionButtonLeast";
            this.radionButtonLeast.Size = new System.Drawing.Size(173, 32);
            this.radionButtonLeast.TabIndex = 1;
            this.radionButtonLeast.TabStop = true;
            this.radionButtonLeast.Text = "Least Like Me";
            this.radionButtonLeast.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonNext.Location = new System.Drawing.Point(757, 137);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(116, 47);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // radioButtonSomewhat
            // 
            this.radioButtonSomewhat.AutoSize = true;
            this.radioButtonSomewhat.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSomewhat.ForeColor = System.Drawing.Color.Black;
            this.radioButtonSomewhat.Location = new System.Drawing.Point(196, 108);
            this.radioButtonSomewhat.Name = "radioButtonSomewhat";
            this.radioButtonSomewhat.Size = new System.Drawing.Size(221, 32);
            this.radioButtonSomewhat.TabIndex = 3;
            this.radioButtonSomewhat.TabStop = true;
            this.radioButtonSomewhat.Text = "Somewhat Like Me";
            this.radioButtonSomewhat.UseVisualStyleBackColor = true;
            // 
            // radioButtonMost
            // 
            this.radioButtonMost.AutoSize = true;
            this.radioButtonMost.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMost.ForeColor = System.Drawing.Color.Black;
            this.radioButtonMost.Location = new System.Drawing.Point(436, 108);
            this.radioButtonMost.Name = "radioButtonMost";
            this.radioButtonMost.Size = new System.Drawing.Size(168, 32);
            this.radioButtonMost.TabIndex = 4;
            this.radioButtonMost.TabStop = true;
            this.radioButtonMost.Text = "Most Like Me";
            this.radioButtonMost.UseVisualStyleBackColor = true;
            // 
            // PersonalityQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 196);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonMost);
            this.Controls.Add(this.radioButtonSomewhat);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.radionButtonLeast);
            this.Controls.Add(this.lblQuestion);
            this.Name = "PersonalityQuestions";
            this.Text = "PersonalityQuestions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton radionButtonLeast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.RadioButton radioButtonSomewhat;
        private System.Windows.Forms.RadioButton radioButtonMost;
    }
}