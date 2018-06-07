namespace WindowsFormsApplication6
{
    partial class Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Register_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("HY강B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(27, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "로그인";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Login_button.Location = new System.Drawing.Point(286, 94);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(90, 73);
            this.Login_button.TabIndex = 10;
            this.Login_button.Text = "로그인";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(133, 144);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(132, 23);
            this.Password.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(133, 95);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(132, 23);
            this.ID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "비밀번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "아이디";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Register_button
            // 
            this.Register_button.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Register_button.Location = new System.Drawing.Point(391, 95);
            this.Register_button.Name = "Register_button";
            this.Register_button.Size = new System.Drawing.Size(90, 72);
            this.Register_button.TabIndex = 12;
            this.Register_button.Text = "회원가입";
            this.Register_button.UseVisualStyleBackColor = true;
            this.Register_button.Click += new System.EventHandler(this.Register_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 212);
            this.Controls.Add(this.Register_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register_button;
    }
}