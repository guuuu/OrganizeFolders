using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            add_form af = new add_form();
            af.ShowDialog();
        }

        private void change_Click(object sender, EventArgs e)
        {
            change cf = new change();
            cf.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            delete del = new delete();
            del.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://guuuu.github.io/gxdev");
        }
    }
}
