namespace VRS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.addRate = new Bunifu.Framework.UI.BunifuRating();
            this.rate_button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rate = new Bunifu.Framework.UI.BunifuRating();
            this.lblLoc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbldesc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.title_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.placename_lable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.description_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.placelocation_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.back_button = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse
            // 
            this.bunifuElipse.ElipseRadius = 5;
            this.bunifuElipse.TargetControl = this;
            // 
            // bunifuDragControl
            // 
            this.bunifuDragControl.Fixed = true;
            this.bunifuDragControl.Horizontal = true;
            this.bunifuDragControl.TargetControl = null;
            this.bunifuDragControl.Vertical = true;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.addRate);
            this.bunifuGradientPanel2.Controls.Add(this.rate_button);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel2.Controls.Add(this.rate);
            this.bunifuGradientPanel2.Controls.Add(this.lblLoc);
            this.bunifuGradientPanel2.Controls.Add(this.lbldesc);
            this.bunifuGradientPanel2.Controls.Add(this.lblName);
            this.bunifuGradientPanel2.Controls.Add(this.title_label);
            this.bunifuGradientPanel2.Controls.Add(this.picBox);
            this.bunifuGradientPanel2.Controls.Add(this.placename_lable);
            this.bunifuGradientPanel2.Controls.Add(this.description_label);
            this.bunifuGradientPanel2.Controls.Add(this.placelocation_label);
            this.bunifuGradientPanel2.Controls.Add(this.back_button);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Navy;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Teal;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Teal;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(699, 918);
            this.bunifuGradientPanel2.TabIndex = 3;
            this.bunifuGradientPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel2_Paint);
            // 
            // addRate
            // 
            this.addRate.BackColor = System.Drawing.Color.Transparent;
            this.addRate.ForeColor = System.Drawing.Color.Goldenrod;
            this.addRate.Location = new System.Drawing.Point(218, 722);
            this.addRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addRate.Name = "addRate";
            this.addRate.Size = new System.Drawing.Size(222, 43);
            this.addRate.TabIndex = 59;
            this.addRate.Value = 0;
            // 
            // rate_button
            // 
            this.rate_button.AllowToggling = false;
            this.rate_button.AnimationSpeed = 100;
            this.rate_button.AutoGenerateColors = false;
            this.rate_button.BackColor = System.Drawing.Color.Transparent;
            this.rate_button.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.rate_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rate_button.BackgroundImage")));
            this.rate_button.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rate_button.ButtonText = "Save Rate";
            this.rate_button.ButtonTextMarginLeft = 0;
            this.rate_button.CausesValidation = false;
            this.rate_button.ColorContrastOnClick = 45;
            this.rate_button.ColorContrastOnHover = 45;
            this.rate_button.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.rate_button.CustomizableEdges = borderEdges1;
            this.rate_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.rate_button.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.rate_button.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rate_button.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.rate_button.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.rate_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_button.ForeColor = System.Drawing.Color.White;
            this.rate_button.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.rate_button.IconMarginLeft = 11;
            this.rate_button.IconPadding = 10;
            this.rate_button.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.rate_button.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.rate_button.IdleBorderRadius = 3;
            this.rate_button.IdleBorderThickness = 2;
            this.rate_button.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.rate_button.IdleIconLeftImage = null;
            this.rate_button.IdleIconRightImage = null;
            this.rate_button.IndicateFocus = false;
            this.rate_button.Location = new System.Drawing.Point(495, 722);
            this.rate_button.Margin = new System.Windows.Forms.Padding(0);
            this.rate_button.Name = "rate_button";
            this.rate_button.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.rate_button.onHoverState.BorderRadius = 3;
            this.rate_button.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rate_button.onHoverState.BorderThickness = 2;
            this.rate_button.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.rate_button.onHoverState.ForeColor = System.Drawing.Color.White;
            this.rate_button.onHoverState.IconLeftImage = null;
            this.rate_button.onHoverState.IconRightImage = null;
            this.rate_button.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rate_button.OnIdleState.BorderRadius = 3;
            this.rate_button.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rate_button.OnIdleState.BorderThickness = 2;
            this.rate_button.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.rate_button.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.rate_button.OnIdleState.IconLeftImage = null;
            this.rate_button.OnIdleState.IconRightImage = null;
            this.rate_button.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rate_button.OnPressedState.BorderRadius = 3;
            this.rate_button.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.rate_button.OnPressedState.BorderThickness = 2;
            this.rate_button.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.rate_button.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.rate_button.OnPressedState.IconLeftImage = null;
            this.rate_button.OnPressedState.IconRightImage = null;
            this.rate_button.Size = new System.Drawing.Size(115, 43);
            this.rate_button.TabIndex = 58;
            this.rate_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rate_button.TextMarginLeft = 0;
            this.rate_button.UseDefaultRadiusAndThickness = true;
            this.rate_button.Click += new System.EventHandler(this.rate_button_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(115, 617);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(97, 43);
            this.bunifuCustomLabel1.TabIndex = 57;
            this.bunifuCustomLabel1.Text = "Rate:";
            // 
            // rate
            // 
            this.rate.BackColor = System.Drawing.Color.Transparent;
            this.rate.Enabled = false;
            this.rate.ForeColor = System.Drawing.Color.Goldenrod;
            this.rate.Location = new System.Drawing.Point(218, 608);
            this.rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(222, 43);
            this.rate.TabIndex = 56;
            this.rate.Value = 0;
            // 
            // lblLoc
            // 
            this.lblLoc.BackColor = System.Drawing.Color.Transparent;
            this.lblLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.White;
            this.lblLoc.Location = new System.Drawing.Point(246, 419);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(400, 62);
            this.lblLoc.TabIndex = 55;
            this.lblLoc.Text = "Place Location...";
            // 
            // lbldesc
            // 
            this.lbldesc.BackColor = System.Drawing.Color.Transparent;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.ForeColor = System.Drawing.Color.White;
            this.lbldesc.Location = new System.Drawing.Point(246, 507);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(423, 86);
            this.lbldesc.TabIndex = 54;
            this.lbldesc.Text = "Place Description...";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(246, 360);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(319, 32);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Place Name...";
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.Transparent;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(68, 33);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(351, 34);
            this.title_label.TabIndex = 52;
            this.title_label.Text = "PLACE INFORMATION";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(75, 105);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(522, 225);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 49;
            this.picBox.TabStop = false;
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // placename_lable
            // 
            this.placename_lable.BackColor = System.Drawing.Color.Transparent;
            this.placename_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placename_lable.ForeColor = System.Drawing.Color.White;
            this.placename_lable.Location = new System.Drawing.Point(100, 360);
            this.placename_lable.Name = "placename_lable";
            this.placename_lable.Size = new System.Drawing.Size(140, 43);
            this.placename_lable.TabIndex = 46;
            this.placename_lable.Text = "Name:";
            // 
            // description_label
            // 
            this.description_label.BackColor = System.Drawing.Color.Transparent;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.ForeColor = System.Drawing.Color.White;
            this.description_label.Location = new System.Drawing.Point(101, 507);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(136, 43);
            this.description_label.TabIndex = 45;
            this.description_label.Text = "Description:";
            // 
            // placelocation_label
            // 
            this.placelocation_label.BackColor = System.Drawing.Color.Transparent;
            this.placelocation_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placelocation_label.ForeColor = System.Drawing.Color.White;
            this.placelocation_label.Location = new System.Drawing.Point(100, 419);
            this.placelocation_label.Name = "placelocation_label";
            this.placelocation_label.Size = new System.Drawing.Size(168, 43);
            this.placelocation_label.TabIndex = 44;
            this.placelocation_label.Text = "Location:";
            // 
            // back_button
            // 
            this.back_button.AllowToggling = false;
            this.back_button.AnimationSpeed = 100;
            this.back_button.AutoGenerateColors = false;
            this.back_button.BackColor = System.Drawing.Color.Transparent;
            this.back_button.BackColor1 = System.Drawing.Color.Crimson;
            this.back_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_button.BackgroundImage")));
            this.back_button.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.back_button.ButtonText = "BACK";
            this.back_button.ButtonTextMarginLeft = 0;
            this.back_button.CausesValidation = false;
            this.back_button.ColorContrastOnClick = 45;
            this.back_button.ColorContrastOnHover = 45;
            this.back_button.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.back_button.CustomizableEdges = borderEdges2;
            this.back_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.back_button.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.back_button.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.back_button.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.back_button.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.IconMarginLeft = 11;
            this.back_button.IconPadding = 10;
            this.back_button.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.back_button.IdleBorderColor = System.Drawing.Color.Crimson;
            this.back_button.IdleBorderRadius = 3;
            this.back_button.IdleBorderThickness = 2;
            this.back_button.IdleFillColor = System.Drawing.Color.Crimson;
            this.back_button.IdleIconLeftImage = null;
            this.back_button.IdleIconRightImage = null;
            this.back_button.IndicateFocus = false;
            this.back_button.Location = new System.Drawing.Point(48, 788);
            this.back_button.Margin = new System.Windows.Forms.Padding(0);
            this.back_button.Name = "back_button";
            this.back_button.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.back_button.onHoverState.BorderRadius = 3;
            this.back_button.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.back_button.onHoverState.BorderThickness = 2;
            this.back_button.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.back_button.onHoverState.ForeColor = System.Drawing.Color.White;
            this.back_button.onHoverState.IconLeftImage = null;
            this.back_button.onHoverState.IconRightImage = null;
            this.back_button.OnIdleState.BorderColor = System.Drawing.Color.Crimson;
            this.back_button.OnIdleState.BorderRadius = 3;
            this.back_button.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.back_button.OnIdleState.BorderThickness = 2;
            this.back_button.OnIdleState.FillColor = System.Drawing.Color.Crimson;
            this.back_button.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.back_button.OnIdleState.IconLeftImage = null;
            this.back_button.OnIdleState.IconRightImage = null;
            this.back_button.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.back_button.OnPressedState.BorderRadius = 3;
            this.back_button.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.back_button.OnPressedState.BorderThickness = 2;
            this.back_button.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.back_button.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.back_button.OnPressedState.IconLeftImage = null;
            this.back_button.OnPressedState.IconRightImage = null;
            this.back_button.Size = new System.Drawing.Size(206, 50);
            this.back_button.TabIndex = 13;
            this.back_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back_button.TextMarginLeft = 0;
            this.back_button.UseDefaultRadiusAndThickness = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 918);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private Bunifu.Framework.UI.BunifuCustomLabel title_label;
        private System.Windows.Forms.PictureBox picBox;
        private Bunifu.Framework.UI.BunifuCustomLabel placename_lable;
        private Bunifu.Framework.UI.BunifuCustomLabel description_label;
        private Bunifu.Framework.UI.BunifuCustomLabel placelocation_label;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton back_button;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLoc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbldesc;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuRating rate;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton rate_button;
        private Bunifu.Framework.UI.BunifuRating addRate;
    }
}