using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class delete : Form
    {
        public delete()
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

            for (int i = 0; i < list.Count; i++)
            {
                items[i] = list[i].ToString().Split('\n')[1].Split(':')[1];
                extensions[i] = list[i].ToString().Split('\n')[0].Split(':')[1];
                exceptions[i] = list[i].ToString().Split('\n')[2].Split(':')[1];
            }

            return new List<string[]>() { items, extensions, exceptions };
        }

        private void delete_Load(object sender, EventArgs e)
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

            for (int i = 0; i < list.Count; i++)
            {
                items[i] = list[i].ToString().Split('\n')[1].Split(':')[1];
            }
            drop.Items = items;
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if(drop.selectedIndex != -1) {
                    List<Extension> list = new List<Extension>() { };
                    string json = String.Empty;
                    string json_path = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)).ToString() + "\\Program Files (x86)\\PFO\\Extensions\\extensions.json";

                    using (StreamReader r = new StreamReader(json_path))
                    {
                        json = r.ReadToEnd();
                    }

                    list = JsonConvert.DeserializeObject<List<Extension>>(json);

                    DialogResult result = MessageBox.Show($"Are you sure you want to delete '{drop.selectedValue}' from the files to be organized?\nThe extensions being organized to this folder are {list[drop.selectedIndex].ToString().Split('\n')[0].Split(':')[1]}", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    Extension ext = new Extension();

                    if (result == DialogResult.Yes)
                        if (ext.delete(drop.selectedIndex))
                            MessageBox.Show("Extension was deleted sucessfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    delete del = new delete();
                    this.Close();
                    del.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select what extensions you don't want to organize!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
