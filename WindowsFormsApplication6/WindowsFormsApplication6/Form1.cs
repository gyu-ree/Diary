using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyStory_Click(object sender, EventArgs e) // 일기 함수
        {
            MyStory_choice mystory = new MyStory_choice(); // 폼클래스 객체 생성
            mystory.ShowDialog(); // 폼을 생성하는 메서드
        }

        private void Schedule_Click(object sender, EventArgs e) // 일정 함수
        {
            Schedule schedule = new Schedule(); // 폼클래스 객체 생성
            schedule.ShowDialog(); // 폼을 생성하는 메서드
        }

        private void Register_Click(object sender, EventArgs e) // 등록 함수
        {
            Login login = new Login(); // 폼클래스 객체 생성
            login.ShowDialog(); // 폼을 생성하는 메서드
        }
    }
}
