namespace VRS
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.user_table = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.makeadmin_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.delete_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.back_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exit_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.user_table);
            this.bunifuGradientPanel1.Controls.Add(this.makeadmin_button);
            this.bunifuGradientPanel1.Controls.Add(this.delete_button);
            this.bunifuGradientPanel1.Controls.Add(this.back_button);
            this.bunifuGradientPanel1.Controls.Add(this.exit_button);
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1117, 717);
            this.bunifuGradientPanel1.TabIndex = 2;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // user_table
            // 
            this.user_table.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.user_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.user_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.user_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.user_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.user_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.user_table.ColumnHeadersHeight = 40;
            this.user_table.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.user_table.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.user_table.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.user_table.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.user_table.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.user_table.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.user_table.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.user_table.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.user_table.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.user_table.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.user_table.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.user_table.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.user_table.CurrentTheme.Name = null;
            this.user_table.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.user_table.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.user_table.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.user_table.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.user_table.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.user_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.user_table.EnableHeadersVisualStyles = false;
            this.user_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.user_table.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.user_table.HeaderBgColor = System.Drawing.Color.Empty;
            this.user_table.HeaderForeColor = System.Drawing.Color.White;
            this.user_table.Location = new System.Drawing.Point(37, 132);
            this.user_table.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user_table.Name = "user_table";
            this.user_table.RowHeadersVisible = false;
            this.user_table.RowTemplate.Height = 40;
            this.user_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.user_table.Size = new System.Drawing.Size(1023, 441);
            this.user_table.TabIndex = 15;
            this.user_table.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.user_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_table_CellContentClick);
            // 
            // makeadmin_button
            // 
            this.makeadmin_button.Active = false;
            this.makeadmin_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.makeadmin_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.makeadmin_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.makeadmin_button.BorderRadius = 0;
            this.makeadmin_button.ButtonText = "Make Admin";
            this.makeadmin_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.makeadmin_button.DisabledColor = System.Drawing.Color.Gray;
            this.makeadmin_button.Iconcolor = System.Drawing.Color.Transparent;
            this.makeadmin_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("makeadmin_button.Iconimage")));
            this.makeadmin_button.Iconimage_right = null;
            this.makeadmin_button.Iconimage_right_Selected = null;
            this.makeadmin_button.Iconimage_Selected = null;
            this.makeadmin_button.IconMarginLeft = 20;
            this.makeadmin_button.IconMarginRight = 0;
            this.makeadmin_button.IconRightVisible = true;
            this.makeadmin_button.IconRightZoom = 0D;
            this.makeadmin_button.IconVisible = true;
            this.makeadmin_button.IconZoom = 90D;
            this.makeadmin_button.IsTab = false;
            this.makeadmin_button.Location = new System.Drawing.Point(222, 41);
            this.makeadmin_button.Margin = new System.Windows.Forms.Padding(0);
            this.makeadmin_button.Name = "makeadmin_button";
            this.makeadmin_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.makeadmin_button.OnHovercolor = System.Drawing.Color.Maroon;
            this.makeadmin_button.OnHoverTextColor = System.Drawing.Color.White;
            this.makeadmin_button.selected = false;
            this.makeadmin_button.Size = new System.Drawing.Size(223, 59);
            this.makeadmin_button.TabIndex = 14;
            this.makeadmin_button.Text = "Make Admin";
            this.makeadmin_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.makeadmin_button.Textcolor = System.Drawing.Color.White;
            this.makeadmin_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeadmin_button.Click += new System.EventHandler(this.makeadmin_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Active = false;
            this.delete_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_button.BorderRadius = 0;
            this.delete_button.ButtonText = "Delete";
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.DisabledColor = System.Drawing.Color.Gray;
            this.delete_button.Iconcolor = System.Drawing.Color.Transparent;
            this.delete_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("delete_button.Iconimage")));
            this.delete_button.Iconimage_right = null;
            this.delete_button.Iconimage_right_Selected = null;
            this.delete_button.Iconimage_Selected = null;
            this.delete_button.IconMarginLeft = 20;
            this.delete_button.IconMarginRight = 0;
            this.delete_button.IconRightVisible = true;
            this.delete_button.IconRightZoom = 0D;
            this.delete_button.IconVisible = true;
            this.delete_button.IconZoom = 90D;
            this.delete_button.IsTab = false;
            this.delete_button.Location = new System.Drawing.Point(523, 41);
            this.delete_button.Margin = new System.Windows.Forms.Padding(0);
            this.delete_button.Name = "delete_button";
            this.delete_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.delete_button.OnHovercolor = System.Drawing.Color.Maroon;
            this.delete_button.OnHoverTextColor = System.Drawing.Color.White;
            this.delete_button.selected = false;
            this.delete_button.Size = new System.Drawing.Size(223, 59);
            this.delete_button.TabIndex = 13;
            this.delete_button.Text = "Delete";
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_button.Textcolor = System.Drawing.Color.White;
            this.delete_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // back_button
            // 
            this.back_button.Active = false;
            this.back_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.back_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_button.BorderRadius = 0;
            this.back_button.ButtonText = "back";
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.DisabledColor = System.Drawing.Color.Gray;
            this.back_button.Iconcolor = System.Drawing.Color.Transparent;
            this.back_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("back_button.Iconimage")));
            this.back_button.Iconimage_right = null;
            this.back_button.Iconimage_right_Selected = null;
            this.back_button.Iconimage_Selected = null;
            this.back_button.IconMarginLeft = 20;
            this.back_button.IconMarginRight = 0;
            this.back_button.IconRightVisible = true;
            this.back_button.IconRightZoom = 0D;
            this.back_button.IconVisible = true;
            this.back_button.IconZoom = 90D;
            this.back_button.IsTab = false;
            this.back_button.Location = new System.Drawing.Point(583, 610);
            this.back_button.Margin = new System.Windows.Forms.Padding(0);
            this.back_button.Name = "back_button";
            this.back_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.back_button.OnHovercolor = System.Drawing.Color.Maroon;
            this.back_button.OnHoverTextColor = System.Drawing.Color.White;
            this.back_button.selected = false;
            this.back_button.Size = new System.Drawing.Size(223, 62);
            this.back_button.TabIndex = 12;
            this.back_button.Text = "back";
            this.back_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_button.Textcolor = System.Drawing.Color.White;
            this.back_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
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
            this.exit_button.Location = new System.Drawing.Point(838, 610);
            this.exit_button.Margin = new System.Windows.Forms.Padding(0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exit_button.OnHovercolor = System.Drawing.Color.Maroon;
            this.exit_button.OnHoverTextColor = System.Drawing.Color.White;
            this.exit_button.selected = false;
            this.exit_button.Size = new System.Drawing.Size(223, 62);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "Exit";
            this.exit_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_button.Textcolor = System.Drawing.Color.White;
            this.exit_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
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
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 717);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuDataGridView user_table;
        private Bunifu.Framework.UI.BunifuFlatButton makeadmin_button;
        private Bunifu.Framework.UI.BunifuFlatButton delete_button;
        private Bunifu.Framework.UI.BunifuFlatButton back_button;
        private Bunifu.Framework.UI.BunifuFlatButton exit_button;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}