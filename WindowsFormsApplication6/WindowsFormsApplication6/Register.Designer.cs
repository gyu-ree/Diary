namespace WindowsFormsApplication6
{
    partial class Register
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
            this.Name = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Register_button = new System.Windows.Forms.Button();
            this.Name_txt = new System.Windows.Forms.TextBox();
            this.Register_label = new System.Windows.Forms.Label();
            this.Age_txt = new System.Windows.Forms.TextBox();
            this.Number_txt = new System.Windows.Forms.TextBox();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name.Location = new System.Drawing.Point(12, 75);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 23);
            this.Name.TabIndex = 0;
            this.Name.Text = "이름";
            this.Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Age.Location = new System.Drawing.Point(12, 116);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(100, 23);
            this.Age.TabIndex = 1;
            this.Age.Text = "나이";
            this.Age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Number
            // 
            this.Number.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Number.Location = new System.Drawing.Point(12, 159);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(100, 23);
            this.Number.TabIndex = 2;
            this.Number.Text = "전화번호";
            this.Number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID.Location = new System.Drawing.Point(12, 210);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 23);
            this.ID.TabIndex = 3;
            this.ID.Text = "아이디";
            this.ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Password.Location = new System.Drawing.Point(12, 263);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 23);
            this.Password.TabIndex = 4;
            this.Password.Text = "비밀번호";
            this.Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register_button
            // 
            this.Register_button.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Register_button.Location = new System.Drawing.Point(246, 308);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(91, 31);
            this.Register_button.TabIndex = 5;
            this.Register_button.Text = "등록";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Name_txt
            // 
            this.Name_txt.Location = new System.Drawing.Point(118, 75);
            this.Name_txt.Multiline = true;
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(159, 23);
            this.Name_txt.TabIndex = 6;
            // 
            // Register_label
            // 
            this.Register_label.Font = new System.Drawing.Font("HY강B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Register_label.Location = new System.Drawing.Point(34, 21);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(119, 40);
            this.Register_label.TabIndex = 11;
            this.Register_label.Text = "회원가입";
            this.Register_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Age_txt
            // 
            this.Age_txt.Location = new System.Drawing.Point(118, 116);
            this.Age_txt.Multiline = true;
            this.Age_txt.Name = "Age_txt";
            this.Age_txt.Size = new System.Drawing.Size(159, 23);
            this.Age_txt.TabIndex = 12;
            // 
            // Number_txt
            // 
            this.Number_txt.Location = new System.Drawing.Point(118, 163);
            this.Number_txt.Multiline = true;
            this.Number_txt.Name = "Number_txt";
            this.Number_txt.Size = new System.Drawing.Size(159, 23);
            this.Number_txt.TabIndex = 13;
            // 
            // ID_txt
            // 
            this.ID_txt.Location = new System.Drawing.Point(118, 214);
            this.ID_txt.Multiline = true;
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(159, 23);
            this.ID_txt.TabIndex = 14;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(118, 263);
            this.Password_txt.Multiline = true;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(159, 23);
            this.Password_txt.TabIndex = 15;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 362);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.Number_txt);
            this.Controls.Add(this.Age_txt);
            this.Controls.Add(this.Register_label);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Name);
            this.MaximizeBox = false;
            //this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Register_button;
        private System.Windows.Forms.TextBox Name_txt;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.TextBox Age_txt;
        private System.Windows.Forms.TextBox Number_txt;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.TextBox Password_txt;
    }
}