namespace Azmari
{
    partial class Ui_ArtistPublish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ui_ArtistPublish));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lblHome = new System.Windows.Forms.Label();
            this.picSongFile = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSongname = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.picSongCover = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPublish = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.picSongFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.SystemColors.Control;
            this.lblHome.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHome.Location = new System.Drawing.Point(12, 9);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(173, 59);
            this.lblHome.TabIndex = 10;
            this.lblHome.Text = "Publish";
            // 
            // picSongFile
            // 
            this.picSongFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSongFile.Image = ((System.Drawing.Image)(resources.GetObject("picSongFile.Image")));
            this.picSongFile.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSongFile.InitialImage")));
            this.picSongFile.Location = new System.Drawing.Point(616, 267);
            this.picSongFile.Name = "picSongFile";
            this.picSongFile.Size = new System.Drawing.Size(106, 102);
            this.picSongFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSongFile.TabIndex = 19;
            this.picSongFile.TabStop = false;
            this.picSongFile.Click += new System.EventHandler(this.PicSong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(22, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 3);
            this.panel2.TabIndex = 21;
            // 
            // txtSongname
            // 
            this.txtSongname.AcceptsReturn = false;
            this.txtSongname.AcceptsTab = false;
            this.txtSongname.AnimationSpeed = 200;
            this.txtSongname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSongname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSongname.BackColor = System.Drawing.Color.Transparent;
            this.txtSongname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSongname.BackgroundImage")));
            this.txtSongname.BorderColorActive = System.Drawing.Color.Transparent;
            this.txtSongname.BorderColorDisabled = System.Drawing.Color.Transparent;
            this.txtSongname.BorderColorHover = System.Drawing.Color.Transparent;
            this.txtSongname.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txtSongname.BorderRadius = 1;
            this.txtSongname.BorderThickness = 1;
            this.txtSongname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSongname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSongname.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txtSongname.DefaultText = "";
            this.txtSongname.FillColor = System.Drawing.SystemColors.Control;
            this.txtSongname.HideSelection = true;
            this.txtSongname.IconLeft = null;
            this.txtSongname.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSongname.IconPadding = 10;
            this.txtSongname.IconRight = null;
            this.txtSongname.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSongname.Lines = new string[0];
            this.txtSongname.Location = new System.Drawing.Point(22, 233);
            this.txtSongname.MaxLength = 32767;
            this.txtSongname.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtSongname.Modified = false;
            this.txtSongname.Multiline = false;
            this.txtSongname.Name = "txtSongname";
            stateProperties1.BorderColor = System.Drawing.Color.Transparent;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSongname.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Transparent;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSongname.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSongname.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Transparent;
            stateProperties4.FillColor = System.Drawing.SystemColors.Control;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSongname.OnIdleState = stateProperties4;
            this.txtSongname.PasswordChar = '\0';
            this.txtSongname.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSongname.PlaceholderText = "Song name";
            this.txtSongname.ReadOnly = false;
            this.txtSongname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSongname.SelectedText = "";
            this.txtSongname.SelectionLength = 0;
            this.txtSongname.SelectionStart = 0;
            this.txtSongname.ShortcutsEnabled = true;
            this.txtSongname.Size = new System.Drawing.Size(243, 35);
            this.txtSongname.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtSongname.TabIndex = 20;
            this.txtSongname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSongname.TextMarginBottom = 0;
            this.txtSongname.TextMarginLeft = 5;
            this.txtSongname.TextMarginTop = 0;
            this.txtSongname.TextPlaceholder = "Song name";
            this.txtSongname.UseSystemPasswordChar = false;
            this.txtSongname.WordWrap = true;
            // 
            // cmbGenre
            // 
            this.cmbGenre.BackColor = System.Drawing.SystemColors.Control;
            this.cmbGenre.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Hip Hop",
            "Pop",
            "Latin",
            "Rock",
            "Country",
            "R&B",
            "Jazz"});
            this.cmbGenre.Location = new System.Drawing.Point(22, 345);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(243, 24);
            this.cmbGenre.TabIndex = 27;
            this.cmbGenre.Text = "Pop";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(17, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 26);
            this.label8.TabIndex = 26;
            this.label8.Text = "Genre ";
            // 
            // picSongCover
            // 
            this.picSongCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSongCover.Image = ((System.Drawing.Image)(resources.GetObject("picSongCover.Image")));
            this.picSongCover.InitialImage = ((System.Drawing.Image)(resources.GetObject("picSongCover.InitialImage")));
            this.picSongCover.Location = new System.Drawing.Point(345, 98);
            this.picSongCover.Name = "picSongCover";
            this.picSongCover.Size = new System.Drawing.Size(106, 102);
            this.picSongCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSongCover.TabIndex = 28;
            this.picSongCover.TabStop = false;
            this.picSongCover.Click += new System.EventHandler(this.PicSongCover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(602, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add music file";
            // 
            // btnPublish
            // 
            this.btnPublish.AllowToggling = false;
            this.btnPublish.AnimationSpeed = 200;
            this.btnPublish.AutoGenerateColors = false;
            this.btnPublish.BackColor = System.Drawing.Color.Transparent;
            this.btnPublish.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPublish.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPublish.BackgroundImage")));
            this.btnPublish.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPublish.ButtonText = "Publish";
            this.btnPublish.ButtonTextMarginLeft = 0;
            this.btnPublish.ColorContrastOnClick = 45;
            this.btnPublish.ColorContrastOnHover = 45;
            this.btnPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPublish.CustomizableEdges = borderEdges1;
            this.btnPublish.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPublish.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnPublish.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPublish.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPublish.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPublish.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.btnPublish.ForeColor = System.Drawing.Color.White;
            this.btnPublish.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublish.IconMarginLeft = 11;
            this.btnPublish.IconPadding = 10;
            this.btnPublish.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPublish.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPublish.IdleBorderRadius = 3;
            this.btnPublish.IdleBorderThickness = 1;
            this.btnPublish.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPublish.IdleIconLeftImage = null;
            this.btnPublish.IdleIconRightImage = null;
            this.btnPublish.IndicateFocus = false;
            this.btnPublish.Location = new System.Drawing.Point(312, 366);
            this.btnPublish.Name = "btnPublish";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.Silver;
            stateProperties5.ForeColor = System.Drawing.Color.Black;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnPublish.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnPublish.OnPressedState = stateProperties6;
            this.btnPublish.Size = new System.Drawing.Size(210, 45);
            this.btnPublish.TabIndex = 30;
            this.btnPublish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPublish.TextMarginLeft = 0;
            this.btnPublish.UseDefaultRadiusAndThickness = true;
            this.btnPublish.Click += new System.EventHandler(this.BtnPublish_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageActive")));
            this.btnClose.Location = new System.Drawing.Point(769, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 34);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 31;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Ui_ArtistPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(59)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(811, 461);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picSongCover);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSongname);
            this.Controls.Add(this.picSongFile);
            this.Controls.Add(this.lblHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ui_ArtistPublish";
            this.Text = "Ui_ArtistPublish";
            this.Load += new System.EventHandler(this.Ui_ArtistPublish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSongFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSongCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox picSongFile;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtSongname;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picSongCover;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPublish;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
    }
}