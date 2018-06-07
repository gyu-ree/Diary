using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication6
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent(); 
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            FileStream ID = new FileStream("ID.txt", FileMode.Append, FileAccess.Write); // 파일입출력 저장
            FileStream PW = new FileStream("PW.txt", FileMode.Append, FileAccess.Write); // 파일입출력 저장
            FileStream member = new FileStream(ID_txt.Text + ".txt", FileMode.Append, FileAccess.Write); // 파일입출력 저장
            StreamWriter register_ID = new StreamWriter(ID); // 
            StreamWriter register_PW = new StreamWriter(PW);
            StreamWriter save_Member = new StreamWriter(member);

            save_Member.WriteLine(Name_txt.Text); // Name_txt에 입력된 값 저장
            save_Member.WriteLine(Age_txt.Text); // Age_txt에 입력된 값 저장
            save_Member.WriteLine(Number_txt.Text); // Number_txt에 입력된 값 저장
            register_ID.WriteLine(ID_txt.Text); // ID_txt에 입력된 값 저장
            register_PW.WriteLine(Password_txt.Text); // Password_txt에 입력된 값 저장

            register_ID.Close();
            register_PW.Close();
            save_Member.Close();
            ID.Close();
            PW.Close();
            member.Close();
        }
    }
}
