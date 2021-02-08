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

namespace Azmari
{
    public partial class Ui_ArtistSignup : Form
    {
        public Ui_ArtistSignup()
        {
            InitializeComponent();
        }

        
        private void BtnSignup_Click(object sender, EventArgs e)
        {
            int flag = 0;

            Artist creator = new Artist();

            MemoryStream ms = new MemoryStream();
            picUser.Image.Save(ms, picUser.Image.RawFormat);
            creator.picture = ms.ToArray();


            creator.fName = txtFname.Text;
            creator.lName = txtLname.Text;
            creator.stageName = txtStagename.Text;
            creator.email = txtEmail.Text;
            creator.password = txtPasswd.Text;

            
            if (rbMale.Checked)
            {
                creator.gender = "M";

            }
            else if (rbFemale.Checked)
            {
                creator.gender = "F";
            }
            else
            {
                errGender.Visible = true;
                flag = 1;
            }

            if (flag == 0)
            {
                creator.saveArtist();
                Ui_UserLogin login = new Ui_UserLogin();
                login.Show();
                this.Close();
            }
        }

        private void Ui_ArtistSignup_Load(object sender, EventArgs e)
        {
            errGender.Visible = false;
        }

        bool mouseFlag = false;
        private void PnlSignup_MouseDown(object sender, MouseEventArgs e)
        {
            mouseFlag = true;
        }

        private void PnlSignup_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseFlag == true)

            {
                this.Location = Cursor.Position;
            }
        }

        private void PnlSignup_MouseUp(object sender, MouseEventArgs e)
        {
            mouseFlag = false;
        }

        private void PicUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "choose Photo (*.jpg; *.png; *.Jpeg; *.bmp;) | *.jpg; *.png; *.Jpeg; *.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picUser.Image = Image.FromFile(op.FileName);
            }
        }
    }
}
