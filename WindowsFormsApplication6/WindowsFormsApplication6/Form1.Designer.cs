namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MyStory = new System.Windows.Forms.Button();
            this.Schedule = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("HY크리스탈M", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(55, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 151);
            this.label1.TabIndex = 0;
            this.label1.Text = "나만의 Diary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyStory
            // 
            this.MyStory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MyStory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyStory.Font = new System.Drawing.Font("HY강B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MyStory.Location = new System.Drawing.Point(80, 302);
            this.MyStory.Name = "MyStory";
            this.MyStory.Size = new System.Drawing.Size(106, 38);
            this.MyStory.TabIndex = 1;
            this.MyStory.Text = "일기";
            this.MyStory.UseVisualStyleBackColor = false;
            this.MyStory.Click += new System.EventHandler(this.MyStory_Click);
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Schedule.Font = new System.Drawing.Font("HY강B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Schedule.Location = new System.Drawing.Point(232, 302);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(106, 38);
            this.Schedule.TabIndex = 2;
            this.Schedule.Text = "일정";
            this.Schedule.UseVisualStyleBackColor = false;
            this.Schedule.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Register.Font = new System.Drawing.Font("HY강B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Register.Location = new System.Drawing.Point(293, 34);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(104, 36);
            this.Register.TabIndex = 4;
            this.Register.Text = "등록!";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(409, 389);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.MyStory);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MyStory;
        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.Button Register;
    }
}

