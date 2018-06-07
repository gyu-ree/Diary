namespace WindowsFormsApplication6
{
    partial class MyStory
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
            this.Save = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sunny = new System.Windows.Forms.RadioButton();
            this.Cloudy = new System.Windows.Forms.RadioButton();
            this.Rain = new System.Windows.Forms.RadioButton();
            this.Snow = new System.Windows.Forms.RadioButton();
            this.Date_choice = new System.Windows.Forms.DateTimePicker();
            this.Story = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Save.Font = new System.Drawing.Font("HY산B", 12F, System.Drawing.FontStyle.Bold);
            this.Save.Location = new System.Drawing.Point(391, 87);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 52);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Date
            // 
            this.Date.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Date.Location = new System.Drawing.Point(18, 29);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(59, 27);
            this.Date.TabIndex = 3;
            this.Date.Text = "날짜";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "날씨";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sunny
            // 
            this.Sunny.Location = new System.Drawing.Point(83, 76);
            this.Sunny.Name = "Sunny";
            this.Sunny.Size = new System.Drawing.Size(104, 24);
            this.Sunny.TabIndex = 6;
            this.Sunny.TabStop = true;
            this.Sunny.Text = "Sunny";
            this.Sunny.UseVisualStyleBackColor = true;
            // 
            // Cloudy
            // 
            this.Cloudy.Location = new System.Drawing.Point(150, 75);
            this.Cloudy.Name = "Cloudy";
            this.Cloudy.Size = new System.Drawing.Size(104, 24);
            this.Cloudy.TabIndex = 7;
            this.Cloudy.TabStop = true;
            this.Cloudy.Text = "Cloudy";
            this.Cloudy.UseVisualStyleBackColor = true;
            // 
            // Rain
            // 
            this.Rain.Location = new System.Drawing.Point(224, 75);
            this.Rain.Name = "Rain";
            this.Rain.Size = new System.Drawing.Size(104, 24);
            this.Rain.TabIndex = 8;
            this.Rain.TabStop = true;
            this.Rain.Text = "Rain";
            this.Rain.UseVisualStyleBackColor = true;
            // 
            // Snow
            // 
            this.Snow.Location = new System.Drawing.Point(292, 75);
            this.Snow.Name = "Snow";
            this.Snow.Size = new System.Drawing.Size(93, 24);
            this.Snow.TabIndex = 9;
            this.Snow.TabStop = true;
            this.Snow.Text = "Snow";
            this.Snow.UseVisualStyleBackColor = true;
            // 
            // Date_choice
            // 
            this.Date_choice.Location = new System.Drawing.Point(83, 35);
            this.Date_choice.Name = "Date_choice";
            this.Date_choice.Size = new System.Drawing.Size(221, 21);
            this.Date_choice.TabIndex = 10;
            // 
            // Story
            // 
            this.Story.Location = new System.Drawing.Point(22, 117);
            this.Story.Multiline = true;
            this.Story.Name = "Story";
            this.Story.Size = new System.Drawing.Size(335, 413);
            this.Story.TabIndex = 11;
            // 
            // MyStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(499, 561);
            this.Controls.Add(this.Story);
            this.Controls.Add(this.Date_choice);
            this.Controls.Add(this.Snow);
            this.Controls.Add(this.Rain);
            this.Controls.Add(this.Cloudy);
            this.Controls.Add(this.Sunny);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Save);
            this.Name = "MyStory";
            this.Text = "MyStory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Sunny;
        private System.Windows.Forms.RadioButton Cloudy;
        private System.Windows.Forms.RadioButton Rain;
        private System.Windows.Forms.RadioButton Snow;
        private System.Windows.Forms.DateTimePicker Date_choice;
        private System.Windows.Forms.TextBox Story;
    }
}