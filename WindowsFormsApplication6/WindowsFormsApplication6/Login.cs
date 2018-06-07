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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e) 
        {
            StreamReader sr = new StreamReader("member.txt");
            string line=null;
            
            
                if (line == ID.Text)
                    MessageBox.Show("성공!");
                
                else
                    MessageBox.Show("실패!");
            

            MyStory mystory = new MyStory();
            mystory.ShowDialog();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }
    }
}
