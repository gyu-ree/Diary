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
    public partial class MyStory : Form
    {
        Form1 form1 = new Form1();
        public MyStory()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FileStream Story = new FileStream("Story.txt", FileMode.Append, FileAccess.Write); // 파일입출력 저장
            StreamWriter MyStory = new StreamWriter(Story); // 

            MyStory.WriteLine(Date_choice.Text);


            MyStory.Close();
            Story.Close();
        }
    }
}
