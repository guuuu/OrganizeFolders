using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class add_form : Form
    {
        public add_form()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string extensions = String.Empty;
            string folder_name = String.Empty;
            string exceptions = String.Empty;
            bool g2,g3,g4 = false;

            if (Regex.IsMatch(txt_extensions.Text, "^[/a-zA-Z0-9\\/./]+$")) { 
                extensions = txt_extensions.Text;
                string aux = String.Empty;

                if (!extensions.EndsWith("/"))
                    extensions += "/";
                if (!extensions.StartsWith("."))
                    extensions = "." + extensions;
                if(extensions.Split('/').Length > 1)
                    for(int i = 0; i < extensions.Split('/').Length - 1; i++)
                        if (!extensions.Split('/')[i].StartsWith("."))
                            aux += "." + extensions.Split('/')[i] + "/";
                        else
                            aux += extensions.Split('/')[i] + "/";
                extensions = aux;
                g2 = true;
            }
            else { 
                MessageBox.Show("Extensions doesn't match the requeirements a-z / A-Z / 0-9 / / / .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                g2 = false;
            }

            if (Regex.IsMatch(txt_fname.Text, "^[/a-zA-Z0-9\\-_ /]+$")) { 
                folder_name = txt_fname.Text;
                if (folder_name.Contains("/"))
                    folder_name = folder_name.Replace("/", "");
                if (folder_name.Contains("\\"))
                    folder_name = folder_name.Replace("\\", "");
                if (folder_name.Contains(":"))
                    folder_name = folder_name.Replace(":", "");
                if (folder_name.Contains("*"))
                    folder_name = folder_name.Replace("*", "");
                if (folder_name.Contains("?"))
                    folder_name = folder_name.Replace("?", "");
                if (folder_name.Contains('"'))
                    folder_name = folder_name.Replace('"'.ToString(), "");
                if (folder_name.Contains("<"))
                    folder_name = folder_name.Replace("<", "");
                if (folder_name.Contains(">"))
                    folder_name = folder_name.Replace(">", "");
                if (folder_name.Contains("|"))
                    folder_name = folder_name.Replace("|", "");

                g3 = true;
            }
            else { 
                MessageBox.Show("Folder name doesn't match the requeirements a-z / A-Z / 0-9 / - / _", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                g3 = false;
            }

            if (Regex.IsMatch(txt_exceptions.Text, "^[/a-zA-Z0-9\\-_\\/ /]+$") || txt_exceptions.Text == String.Empty) { 
                exceptions = txt_exceptions.Text;

                if(exceptions != "")
                    if (!exceptions.EndsWith("/"))
                        exceptions += "/";

                g4 = true;
            }
            else { 
                MessageBox.Show("Exception file name doesn't match the requeirements (a-z)/(A-Z)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                g4 = false;
            }

            if(g2 && g3 && g4)
            {
                Extension ext = new Extension(extensions.Replace(" ", ""), folder_name.Replace(" ", ""), exceptions.Replace(" ", ""));

                if (ext.create(ext))
                {
                    MessageBox.Show("Extension was added sucessfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_extensions.Text = String.Empty;
                    txt_fname.Text = String.Empty;
                    txt_exceptions.Text = String.Empty;
                    txt_extensions.Focus();
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if(cancel.Text == "Clear") { 
                txt_extensions.Text = String.Empty;
                txt_fname.Text = String.Empty;
                txt_exceptions.Text = String.Empty;
            }
            else { 
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt_extensions.Text == String.Empty && txt_fname.Text == String.Empty && txt_exceptions.Text == String.Empty)
                cancel.Text = "Close";
            else
                cancel.Text = "Clear";
        }

        private void add_form_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void txt_extensions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ' ')
                e.KeyChar = '/';
        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = '/';
        }

        private void txt_exceptions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.KeyChar = '/';
        }
    }
}
