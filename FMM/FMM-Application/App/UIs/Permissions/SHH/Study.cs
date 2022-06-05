using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMM_Application.App.UIs.Permissions.SHH
{
    public partial class Study : Form
    {
        public Study()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Files f = new Files();
            f.ShowDialog();
        }
    }
}
