namespace GUI
{
    partial class change
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drop = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_exceptions = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_fname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_extensions = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(197, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(190, 24);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Change extensions";
            // 
            // drop
            // 
            this.drop.BackColor = System.Drawing.Color.Transparent;
            this.drop.BorderRadius = 3;
            this.drop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drop.ForeColor = System.Drawing.Color.White;
            this.drop.Items = new string[0];
            this.drop.Location = new System.Drawing.Point(188, 65);
            this.drop.Name = "drop";
            this.drop.NomalColor = System.Drawing.Color.Transparent;
            this.drop.onHoverColor = System.Drawing.Color.Transparent;
            this.drop.selectedIndex = -1;
            this.drop.Size = new System.Drawing.Size(397, 35);
            this.drop.TabIndex = 1;
            this.drop.onItemSelected += new System.EventHandler(this.drop_onItemSelected);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 65);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(176, 22);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Choose extension:";
            // 
            // cancel
            // 
            this.cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.BorderRadius = 0;
            this.cancel.ButtonText = "Cancel";
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.DisabledColor = System.Drawing.Color.Gray;
            this.cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.cancel.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancel.Iconimage")));
            this.cancel.Iconimage_right = null;
            this.cancel.Iconimage_right_Selected = null;
            this.cancel.Iconimage_Selected = null;
            this.cancel.IconMarginLeft = 0;
            this.cancel.IconMarginRight = 0;
            this.cancel.IconRightVisible = true;
            this.cancel.IconRightZoom = 0D;
            this.cancel.IconVisible = true;
            this.cancel.IconZoom = 90D;
            this.cancel.IsTab = false;
            this.cancel.Location = new System.Drawing.Point(42, 285);
            this.cancel.Name = "cancel";
            this.cancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.cancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.cancel.selected = false;
            this.cancel.Size = new System.Drawing.Size(248, 59);
            this.cancel.TabIndex = 18;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel.Textcolor = System.Drawing.Color.White;
            this.cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.BorderRadius = 0;
            this.save.ButtonText = "Save";
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
            this.save.Location = new System.Drawing.Point(337, 285);
            this.save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save.Name = "save";
            this.save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.save.OnHoverTextColor = System.Drawing.Color.White;
            this.save.selected = false;
            this.save.Size = new System.Drawing.Size(248, 59);
            this.save.TabIndex = 17;
            this.save.Text = "Save";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save.Textcolor = System.Drawing.Color.White;
            this.save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // txt_exceptions
            // 
            this.txt_exceptions.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_exceptions.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_exceptions.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_exceptions.BorderThickness = 3;
            this.txt_exceptions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_exceptions.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exceptions.ForeColor = System.Drawing.Color.White;
            this.txt_exceptions.isPassword = false;
            this.txt_exceptions.Location = new System.Drawing.Point(186, 237);
            this.txt_exceptions.Margin = new System.Windows.Forms.Padding(7);
            this.txt_exceptions.Name = "txt_exceptions";
            this.txt_exceptions.Size = new System.Drawing.Size(399, 36);
            this.txt_exceptions.TabIndex = 16;
            this.txt_exceptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_exceptions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_exceptions_KeyPress);
            // 
            // txt_fname
            // 
            this.txt_fname.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_fname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_fname.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_fname.BorderThickness = 3;
            this.txt_fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fname.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.Color.White;
            this.txt_fname.isPassword = false;
            this.txt_fname.Location = new System.Drawing.Point(186, 175);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(7);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(399, 36);
            this.txt_fname.TabIndex = 15;
            this.txt_fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fname_KeyPress);
            // 
            // txt_extensions
            // 
            this.txt_extensions.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_extensions.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_extensions.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_extensions.BorderThickness = 3;
            this.txt_extensions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_extensions.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_extensions.ForeColor = System.Drawing.Color.White;
            this.txt_extensions.isPassword = false;
            this.txt_extensions.Location = new System.Drawing.Point(186, 113);
            this.txt_extensions.Margin = new System.Windows.Forms.Padding(7);
            this.txt_extensions.Name = "txt_extensions";
            this.txt_extensions.Size = new System.Drawing.Size(399, 36);
            this.txt_extensions.TabIndex = 14;
            this.txt_extensions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_extensions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_extensions_KeyPress);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(68, 243);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(120, 24);
            this.bunifuCustomLabel4.TabIndex = 13;
            this.bunifuCustomLabel4.Text = "Exceptions:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(50, 181);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(138, 24);
            this.bunifuCustomLabel3.TabIndex = 12;
            this.bunifuCustomLabel3.Text = "Folder Name:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(69, 119);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(119, 24);
            this.bunifuCustomLabel5.TabIndex = 11;
            this.bunifuCustomLabel5.Text = "Extensions:";
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
            this.exit.Location = new System.Drawing.Point(577, -2);
            this.exit.Name = "exit";
            this.exit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(25)))), ((int)(((byte)(21)))));
            this.exit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))));
            this.exit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(18)))), ((int)(((byte)(15)))));
            this.exit.selected = false;
            this.exit.Size = new System.Drawing.Size(48, 48);
            this.exit.TabIndex = 19;
            this.exit.Text = "bunifuFlatButton1";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Textcolor = System.Drawing.Color.White;
            this.exit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(151)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(623, 360);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.txt_exceptions);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.txt_extensions);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.drop);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "change";
            this.Load += new System.EventHandler(this.change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown drop;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton cancel;
        private Bunifu.Framework.UI.BunifuFlatButton save;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_exceptions;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_fname;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_extensions;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuFlatButton exit;
        private System.Windows.Forms.Timer timer1;
    }
}