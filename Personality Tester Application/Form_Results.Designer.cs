namespace Personality_Tester_Application
{
    partial class Form_Results
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PersonalityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonExit = new System.Windows.Forms.Button();
            this.lblResultColor = new System.Windows.Forms.Label();
            this.lblmulti = new System.Windows.Forms.Label();
            this.labeljob = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.textBoxPersonalityColor = new System.Windows.Forms.TextBox();
            this.textBoxLetterPersonality = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalityChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PersonalityChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PersonalityChart.Legends.Add(legend1);
            this.PersonalityChart.Location = new System.Drawing.Point(12, 12);
            this.PersonalityChart.Name = "PersonalityChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Colour";
            this.PersonalityChart.Series.Add(series1);
            this.PersonalityChart.Size = new System.Drawing.Size(288, 261);
            this.PersonalityChart.TabIndex = 0;
            this.PersonalityChart.Text = "chart1";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(932, 433);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 40);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Finish";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // lblResultColor
            // 
            this.lblResultColor.AutoSize = true;
            this.lblResultColor.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultColor.ForeColor = System.Drawing.Color.Black;
            this.lblResultColor.Location = new System.Drawing.Point(327, 81);
            this.lblResultColor.Name = "lblResultColor";
            this.lblResultColor.Size = new System.Drawing.Size(175, 22);
            this.lblResultColor.TabIndex = 2;
            this.lblResultColor.Text = "Your Color and Type";
            // 
            // lblmulti
            // 
            this.lblmulti.AutoSize = true;
            this.lblmulti.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmulti.ForeColor = System.Drawing.Color.Black;
            this.lblmulti.Location = new System.Drawing.Point(327, 33);
            this.lblmulti.Name = "lblmulti";
            this.lblmulti.Size = new System.Drawing.Size(173, 22);
            this.lblmulti.TabIndex = 3;
            this.lblmulti.Text = "MultipleIntelligence";
            // 
            // labeljob
            // 
            this.labeljob.AutoSize = true;
            this.labeljob.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljob.ForeColor = System.Drawing.Color.Black;
            this.labeljob.Location = new System.Drawing.Point(327, 120);
            this.labeljob.Name = "labeljob";
            this.labeljob.Size = new System.Drawing.Size(34, 22);
            this.labeljob.TabIndex = 4;
            this.labeljob.Text = "job";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(320, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 26);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Color Description";
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLetter.Location = new System.Drawing.Point(613, 210);
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(303, 26);
            this.textBoxLetter.TabIndex = 6;
            this.textBoxLetter.Text = "Personality Letter Description";
            // 
            // textBoxPersonalityColor
            // 
            this.textBoxPersonalityColor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersonalityColor.Location = new System.Drawing.Point(320, 242);
            this.textBoxPersonalityColor.Multiline = true;
            this.textBoxPersonalityColor.Name = "textBoxPersonalityColor";
            this.textBoxPersonalityColor.Size = new System.Drawing.Size(275, 196);
            this.textBoxPersonalityColor.TabIndex = 7;
            this.textBoxPersonalityColor.Text = " ";
            // 
            // textBoxLetterPersonality
            // 
            this.textBoxLetterPersonality.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLetterPersonality.Location = new System.Drawing.Point(613, 242);
            this.textBoxLetterPersonality.Multiline = true;
            this.textBoxLetterPersonality.Name = "textBoxLetterPersonality";
            this.textBoxLetterPersonality.Size = new System.Drawing.Size(303, 196);
            this.textBoxLetterPersonality.TabIndex = 8;
            this.textBoxLetterPersonality.Text = " ";
            // 
            // Form_Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 485);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxLetterPersonality);
            this.Controls.Add(this.textBoxPersonalityColor);
            this.Controls.Add(this.textBoxLetter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labeljob);
            this.Controls.Add(this.lblmulti);
            this.Controls.Add(this.lblResultColor);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.PersonalityChart);
            this.Name = "Form_Results";
            this.Text = "Form_Results";
            this.Load += new System.EventHandler(this.Form_Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalityChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PersonalityChart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label lblResultColor;
        private System.Windows.Forms.Label lblmulti;
        private System.Windows.Forms.Label labeljob;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.TextBox textBoxPersonalityColor;
        private System.Windows.Forms.TextBox textBoxLetterPersonality;
    }
}