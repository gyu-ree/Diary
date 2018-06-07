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
    public partial class MyStory_choice : Form
    {
        public MyStory_choice()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            MyStory_list mystory = new MyStory_list();
            mystory.ShowDialog();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            MyStory story = new MyStory();
            story.ShowDialog();
        }
    }
}
