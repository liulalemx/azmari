namespace Azmari
{
    partial class Ui_ListenerSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ui_ListenerSearch));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataMusic = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnLoadSongs = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.songPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.songName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.Control;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(159, 59);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Search";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.SystemColors.Control;
            this.lblFname.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFname.Location = new System.Drawing.Point(12, 101);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(145, 35);
            this.lblFname.TabIndex = 11;
            this.lblFname.Text = "First name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.SystemColors.Control;
            this.lblLname.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLname.Location = new System.Drawing.Point(220, 101);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(140, 35);
            this.lblLname.TabIndex = 12;
            this.lblLname.Text = "Last name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEmail.Location = new System.Drawing.Point(420, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(83, 35);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(12, 153);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(152, 22);
            this.txtFname.TabIndex = 14;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(220, 153);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(152, 22);
            this.txtLname.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(419, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // dataMusic
            // 
            this.dataMusic.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataMusic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMusic.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataMusic.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMusic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMusic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songPic,
            this.songName,
            this.songArtist,
            this.songGenre,
            this.Email});
            this.dataMusic.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataMusic.DoubleBuffered = true;
            this.dataMusic.EnableHeadersVisualStyles = false;
            this.dataMusic.HeaderBgColor = System.Drawing.Color.Black;
            this.dataMusic.HeaderForeColor = System.Drawing.Color.White;
            this.dataMusic.Location = new System.Drawing.Point(12, 197);
            this.dataMusic.MultiSelect = false;
            this.dataMusic.Name = "dataMusic";
            this.dataMusic.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataMusic.RowHeadersWidth = 51;
            this.dataMusic.RowTemplate.Height = 35;
            this.dataMusic.Size = new System.Drawing.Size(775, 235);
            this.dataMusic.TabIndex = 17;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageActive")));
            this.btnSearch.Location = new System.Drawing.Point(739, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 47);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 18;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnLoadSongs
            // 
            this.btnLoadSongs.AllowToggling = false;
            this.btnLoadSongs.AnimationSpeed = 200;
            this.btnLoadSongs.AutoGenerateColors = false;
            this.btnLoadSongs.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadSongs.BackColor1 = System.Drawing.Color.Black;
            this.btnLoadSongs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadSongs.BackgroundImage")));
            this.btnLoadSongs.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLoadSongs.ButtonText = "Load Songs";
            this.btnLoadSongs.ButtonTextMarginLeft = 0;
            this.btnLoadSongs.ColorContrastOnClick = 45;
            this.btnLoadSongs.ColorContrastOnHover = 45;
            this.btnLoadSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnLoadSongs.CustomizableEdges = borderEdges1;
            this.btnLoadSongs.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoadSongs.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnLoadSongs.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLoadSongs.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLoadSongs.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLoadSongs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnLoadSongs.ForeColor = System.Drawing.Color.White;
            this.btnLoadSongs.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadSongs.IconMarginLeft = 11;
            this.btnLoadSongs.IconPadding = 10;
            this.btnLoadSongs.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadSongs.IdleBorderColor = System.Drawing.Color.White;
            this.btnLoadSongs.IdleBorderRadius = 3;
            this.btnLoadSongs.IdleBorderThickness = 1;
            this.btnLoadSongs.IdleFillColor = System.Drawing.Color.Black;
            this.btnLoadSongs.IdleIconLeftImage = null;
            this.btnLoadSongs.IdleIconRightImage = null;
            this.btnLoadSongs.IndicateFocus = false;
            this.btnLoadSongs.Location = new System.Drawing.Point(326, 438);
            this.btnLoadSongs.Name = "btnLoadSongs";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            stateProperties1.ForeColor = System.Drawing.Color.Black;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnLoadSongs.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnLoadSongs.OnPressedState = stateProperties2;
            this.btnLoadSongs.Size = new System.Drawing.Size(161, 49);
            this.btnLoadSongs.TabIndex = 19;
            this.btnLoadSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadSongs.TextMarginLeft = 0;
            this.btnLoadSongs.UseDefaultRadiusAndThickness = true;
            this.btnLoadSongs.Click += new System.EventHandler(this.BtnLoadSongs_Click);
            // 
            // songPic
            // 
            this.songPic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.songPic.HeaderText = "Artist";
            this.songPic.MinimumWidth = 6;
            this.songPic.Name = "songPic";
            // 
            // songName
            // 
            this.songName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.songName.HeaderText = "First Name";
            this.songName.MinimumWidth = 6;
            this.songName.Name = "songName";
            // 
            // songArtist
            // 
            this.songArtist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.songArtist.HeaderText = "Last name";
            this.songArtist.MinimumWidth = 6;
            this.songArtist.Name = "songArtist";
            // 
            // songGenre
            // 
            this.songGenre.HeaderText = "Stage name";
            this.songGenre.MinimumWidth = 6;
            this.songGenre.Name = "songGenre";
            this.songGenre.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Ui_ListenerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(59)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.btnLoadSongs);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataMusic);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblSearch);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ui_ListenerSearch";
            this.Text = "Ui_ListenerSearch";
            this.Load += new System.EventHandler(this.Ui_ListenerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataMusic;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLoadSongs;
        private System.Windows.Forms.DataGridViewImageColumn songPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn songName;
        private System.Windows.Forms.DataGridViewTextBoxColumn songArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn songGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}