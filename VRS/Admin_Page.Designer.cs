namespace VRS
{
    partial class Admin_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Page));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.title_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.addplaces_button = new Bunifu.Framework.UI.BunifuTileButton();
            this.places_button = new Bunifu.Framework.UI.BunifuTileButton();
            this.requset_button = new Bunifu.Framework.UI.BunifuTileButton();
            this.exit_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.users_button = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.title_label);
            this.bunifuGradientPanel1.Controls.Add(this.addplaces_button);
            this.bunifuGradientPanel1.Controls.Add(this.places_button);
            this.bunifuGradientPanel1.Controls.Add(this.requset_button);
            this.bunifuGradientPanel1.Controls.Add(this.exit_button);
            this.bunifuGradientPanel1.Controls.Add(this.users_button);
            this.bunifuGradientPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1084, 662);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(117, 32);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(219, 52);
            this.title_label.TabIndex = 15;
            this.title_label.Text = "Admin Page";
            // 
            // addplaces_button
            // 
            this.addplaces_button.BackColor = System.Drawing.Color.Transparent;
            this.addplaces_button.color = System.Drawing.Color.Transparent;
            this.addplaces_button.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.addplaces_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addplaces_button.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.addplaces_button.ForeColor = System.Drawing.Color.White;
            this.addplaces_button.Image = ((System.Drawing.Image)(resources.GetObject("addplaces_button.Image")));
            this.addplaces_button.ImagePosition = 20;
            this.addplaces_button.ImageZoom = 50;
            this.addplaces_button.LabelPosition = 41;
            this.addplaces_button.LabelText = "Add Places";
            this.addplaces_button.Location = new System.Drawing.Point(463, 364);
            this.addplaces_button.Margin = new System.Windows.Forms.Padding(7);
            this.addplaces_button.Name = "addplaces_button";
            this.addplaces_button.Size = new System.Drawing.Size(239, 215);
            this.addplaces_button.TabIndex = 14;
            this.addplaces_button.Click += new System.EventHandler(this.addplaces_button_Click);
            // 
            // places_button
            // 
            this.places_button.BackColor = System.Drawing.Color.Transparent;
            this.places_button.color = System.Drawing.Color.Transparent;
            this.places_button.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.places_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.places_button.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.places_button.ForeColor = System.Drawing.Color.White;
            this.places_button.Image = ((System.Drawing.Image)(resources.GetObject("places_button.Image")));
            this.places_button.ImagePosition = 20;
            this.places_button.ImageZoom = 50;
            this.places_button.LabelPosition = 41;
            this.places_button.LabelText = "Places";
            this.places_button.Location = new System.Drawing.Point(196, 364);
            this.places_button.Margin = new System.Windows.Forms.Padding(7);
            this.places_button.Name = "places_button";
            this.places_button.Size = new System.Drawing.Size(239, 215);
            this.places_button.TabIndex = 13;
            this.places_button.Click += new System.EventHandler(this.places_button_Click);
            // 
            // requset_button
            // 
            this.requset_button.BackColor = System.Drawing.Color.Transparent;
            this.requset_button.color = System.Drawing.Color.Transparent;
            this.requset_button.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.requset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requset_button.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.requset_button.ForeColor = System.Drawing.Color.White;
            this.requset_button.Image = ((System.Drawing.Image)(resources.GetObject("requset_button.Image")));
            this.requset_button.ImagePosition = 20;
            this.requset_button.ImageZoom = 50;
            this.requset_button.LabelPosition = 41;
            this.requset_button.LabelText = "Requests";
            this.requset_button.Location = new System.Drawing.Point(463, 117);
            this.requset_button.Margin = new System.Windows.Forms.Padding(7);
            this.requset_button.Name = "requset_button";
            this.requset_button.Size = new System.Drawing.Size(239, 215);
            this.requset_button.TabIndex = 12;
            this.requset_button.Click += new System.EventHandler(this.requset_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Active = false;
            this.exit_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button.BorderRadius = 0;
            this.exit_button.ButtonText = "Exit";
            this.exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_button.DisabledColor = System.Drawing.Color.Gray;
            this.exit_button.Iconcolor = System.Drawing.Color.Transparent;
            this.exit_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("exit_button.Iconimage")));
            this.exit_button.Iconimage_right = null;
            this.exit_button.Iconimage_right_Selected = null;
            this.exit_button.Iconimage_Selected = null;
            this.exit_button.IconMarginLeft = 20;
            this.exit_button.IconMarginRight = 0;
            this.exit_button.IconRightVisible = true;
            this.exit_button.IconRightZoom = 0D;
            this.exit_button.IconVisible = true;
            this.exit_button.IconZoom = 90D;
            this.exit_button.IsTab = false;
            this.exit_button.Location = new System.Drawing.Point(835, 556);
            this.exit_button.Margin = new System.Windows.Forms.Padding(0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exit_button.OnHovercolor = System.Drawing.Color.Maroon;
            this.exit_button.OnHoverTextColor = System.Drawing.Color.White;
            this.exit_button.selected = false;
            this.exit_button.Size = new System.Drawing.Size(223, 73);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "Exit";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_button.Textcolor = System.Drawing.Color.White;
            this.exit_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // users_button
            // 
            this.users_button.BackColor = System.Drawing.Color.Transparent;
            this.users_button.color = System.Drawing.Color.Transparent;
            this.users_button.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.users_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users_button.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.users_button.ForeColor = System.Drawing.Color.White;
            this.users_button.Image = ((System.Drawing.Image)(resources.GetObject("users_button.Image")));
            this.users_button.ImagePosition = 20;
            this.users_button.ImageZoom = 50;
            this.users_button.LabelPosition = 41;
            this.users_button.LabelText = "Users";
            this.users_button.Location = new System.Drawing.Point(196, 117);
            this.users_button.Margin = new System.Windows.Forms.Padding(7);
            this.users_button.Name = "users_button";
            this.users_button.Size = new System.Drawing.Size(239, 215);
            this.users_button.TabIndex = 10;
            this.users_button.Click += new System.EventHandler(this.users_button_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Admin_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 662);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Page";
            this.Load += new System.EventHandler(this.Admin_Page_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel title_label;
        private Bunifu.Framework.UI.BunifuTileButton addplaces_button;
        private Bunifu.Framework.UI.BunifuTileButton places_button;
        private Bunifu.Framework.UI.BunifuTileButton requset_button;
        private Bunifu.Framework.UI.BunifuFlatButton exit_button;
        private Bunifu.Framework.UI.BunifuTileButton users_button;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}