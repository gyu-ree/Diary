namespace WindowsFormsApplication6
{
    partial class MyStory_choice
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
            this.Read = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Read.Font = new System.Drawing.Font("HY강B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Read.Location = new System.Drawing.Point(34, 63);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(115, 54);
            this.Read.TabIndex = 0;
            this.Read.Text = "일기 보기";
            this.Read.UseVisualStyleBackColor = false;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Write
            // 
            this.Write.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Write.Font = new System.Drawing.Font("HY강B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Write.Location = new System.Drawing.Point(194, 63);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(115, 54);
            this.Write.TabIndex = 1;
            this.Write.Text = "일기 쓰기";
            this.Write.UseVisualStyleBackColor = false;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // MyStory_choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(355, 187);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.Read);
            this.Name = "MyStory_choice";
            this.Text = "MyStory_choice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Write;
    }
}