using System;
using System.Linq;
using System.Windows.Forms;
using WIUT.DAL;

namespace WIUT
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            // var cm = new CourseManager();
            // MessageBox.Show(cm.GetAll().Count.ToString());
            // MessageBox.Show(new CourseManager().GetAll().Count.ToString());
            // MessageBox.Show(new CourseManager().GetAll().First().Name);



        }
    }
}
