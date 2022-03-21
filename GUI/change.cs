using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class change : Form
    {
        public change()
        {
            InitializeComponent();
        }

        private List<string[]> FolderNames()
        {
            List<Extension> list = new List<Extension>() { };
            string json = String.Empty;
            string json_path = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)).ToString() + "\\Program Files (x86)\\PFO\\Extensions\\extensions.json";

            using (StreamReader r = new StreamReader(json_path))
            {
                json = r.ReadToEnd();
            }

            list = JsonConvert.DeserializeObject<List<Extension>>(json);

            string[] items = new string[list.Count];
            string[] extensions = new string[list.Count];
            string[] exceptions = new string[list.Count];

            for (int i = 0; i < list.Count; i++) { 
                items[i] = list[i].ToString().Split('\n')[1].Split(':')[1];
                extensions[i] = list[i].ToString().Split('\n')[0].Split(':')[1];
                exceptions[i] = list[i].ToString().Split('\n')[2].Split(':')[1];
            }

            return new List<string[]>() { items, extensions, exceptions };
        }

        private void change_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();

            drop.Items = FolderNames()[0];
        }

        private void drop_onItemSelected(object sender, EventArgs e)
        {
            string[] fn = FolderNames()[0];
            string[] ext = FolderNames()[1];
            string[] excp = FolderNames()[2];

            txt_exceptions.Text = excp[drop.selectedIndex];
            txt_fname.Text = fn[drop.selectedIndex];
            txt_extensions.Text = ext[drop.selectedIndex];
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (cancel.Text == "Clear")
            {
                txt_extensions.Text = String.Empty;
                txt_fname.Text = String.Empty;
                txt_exceptions.Text = String.Empty;
            }
            else
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt_extensions.Text == String.Empty && txt_fname.Text == String.Empty && txt_exceptions.Text == String.Empty)
                cancel.Text = "Close";
            else
                cancel.Text = "Clear";

            txt_extensions.Text = txt_extensions.Text.Replace(" ", "");
            txt_fname.Text = txt_fname.Text.Replace(" ", "");
            txt_exceptions.Text = txt_exceptions.Text.Replace(" ", "");
        }

        private void save_Click(object sender, EventArgs e)
        {
            string extensions = String.Empty;
            string folder_name = String.Empty;
            string exceptions = String.Empty;
            bool g2, g3, g4 = false;
            txt_extensions.Text = txt_extensions.Text.Replace(" ", "");
            txt_fname.Text = txt_fname.Text.Replace(" ", "");
            txt_exceptions.Text = txt_exceptions.Text.Replace(" ", "");

            if (Regex.IsMatch(txt_extensions.Text, "^[/a-zA-Z0-9\\/./]+$"))
            {
                extensions = txt_extensions.Text;
                string aux = String.Empty;

                if (!extensions.EndsWith("/"))
                    extensions += "/";
                if (!extensions.StartsWith("."))
                    extensions = "." + extensions;
                if (extensions.Split('/').Length > 1)
                    for (int i = 0; i < extensions.Split('/').Length - 1; i++)
                        if (!extensions.Split('/')[i].StartsWith("."))
                            aux += "." + extensions.Split('/')[i] + "/";
                        else
                            aux += extensions.Split('/')[i] + "/";
                extensions = aux;
                g2 = true;
            }
            else
            {
                MessageBox.Show("Extensions doesn't match the requeirements a-z / A-Z / 0-9 / / / .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                g2 = false;
            }

            if (Regex.IsMatch(txt_fname.Text, "^[/a-zA-Z0-9\\-_ /]+$"))
            {
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
            else
            {
                MessageBox.Show("Folder name doesn't match the requeirements a-z / A-Z / 0-9 / - / _", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                g3 = false;
            }

            if (Regex.IsMatch(txt_exceptions.Text, "^[/a-zA-Z0-9\\-_\\/ /]+$") || txt_exceptions.Text == String.Empty)
            {
                exceptions = txt_exceptions.Text;

                if (exceptions != "")
                    if (!exceptions.EndsWith("/"))
                        exceptions += "/";

                g4 = true;
            }
            else
            {
                MessageBox.Show("Exception file name doesn't match the requeirements (a-z)/(A-Z)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                g4 = false;
            }

            if (g2 && g3 && g4)
            {
                Extension ext = new Extension(extensions, folder_name, exceptions);

                if (ext.change(ext, drop.selectedIndex))
                {
                    MessageBox.Show("Extension was updated sucessfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    change c = new change();
                    this.Close();
                    c.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_extensions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
