namespace GUI
{
    partial class delete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete));
            this.exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drop = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(25)))), ((int)(((byte)(21)))));
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(25)))), ((int)(((byte)(21)))));
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.BorderRadius = 0;
            this.exit.ButtonText = "bunifuFlatButton1";
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.DisabledColor = System.Drawing.Color.Gray;
            this.exit.Iconcolor = System.Drawing.Color.Transparent;
            this.exit.Iconimage = ((System.Drawing.Image)(resources.GetObject("exit.Iconimage")));
            this.exit.Iconimage_right = null;
            this.exit.Iconimage_right_Selected = null;
            this.exit.Iconimage_Selected = null;
            this.exit.IconMarginLeft = 0;
            this.exit.IconMarginRight = 0;
            this.exit.IconRightVisible = true;
            this.exit.IconRightZoom = 0D;
            this.exit.IconVisible = true;
            this.exit.IconZoom = 90D;
            this.exit.IsTab = false;
            this.exit.Location = new System.Drawing.Point(376, 0);
            this.exit.Name = "exit";
            this.exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(25)))), ((int)(((byte)(21)))));
            this.exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))));
            this.exit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))));
            this.exit.selected = false;
            this.exit.Size = new System.Drawing.Size(48, 48);
            this.exit.TabIndex = 23;
            this.exit.Text = "bunifuFlatButton1";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Textcolor = System.Drawing.Color.White;
            this.exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 67);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(166, 22);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Delete extension:";
            // 
            // drop
            // 
            this.drop.BackColor = System.Drawing.Color.Transparent;
            this.drop.BorderRadius = 3;
            this.drop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drop.ForeColor = System.Drawing.Color.White;
            this.drop.Items = new string[0];
            this.drop.Location = new System.Drawing.Point(189, 61);
            this.drop.Name = "drop";
            this.drop.NomalColor = System.Drawing.Color.Transparent;
            this.drop.onHoverColor = System.Drawing.Color.Transparent;
            this.drop.selectedIndex = -1;
            this.drop.Size = new System.Drawing.Size(217, 35);
            this.drop.TabIndex = 21;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(123, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(177, 24);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Text = "Delete extensions";
            // 
            // save
            // 
            this.save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.BorderRadius = 0;
            this.save.ButtonText = "Delete";
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.DisabledColor = System.Drawing.Color.Gray;
            this.save.Iconcolor = System.Drawing.Color.Transparent;
            this.save.Iconimage = ((System.Drawing.Image)(resources.GetObject("save.Iconimage")));
            this.save.Iconimage_right = null;
            this.save.Iconimage_right_Selected = null;
            this.save.Iconimage_Selected = null;
            this.save.IconMarginLeft = 0;
            this.save.IconMarginRight = 0;
            this.save.IconRightVisible = true;
            this.save.IconRightZoom = 0D;
            this.save.IconVisible = true;
            this.save.IconZoom = 90D;
            this.save.IsTab = false;
            this.save.Location = new System.Drawing.Point(16, 123);
            this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save.Name = "save";
            this.save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.save.OnHoverTextColor = System.Drawing.Color.White;
            this.save.selected = false;
            this.save.Size = new System.Drawing.Size(390, 59);
            this.save.TabIndex = 24;
            this.save.Text = "Delete";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save.Textcolor = System.Drawing.Color.White;
            this.save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(422, 208);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.drop);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton exit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown drop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton save;
    }
}