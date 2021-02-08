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
    public partial class Ui_UserUpdate : Form
    {
        public Ui_UserUpdate()
        {
            InitializeComponent();
        }

        public string userEmail;
        public string userPasswd;
        
        private void Ui_UserUpdate_Load(object sender, EventArgs e)
        {
            errGender.Visible = false;
        }

        Ui_ListenerHome list = null;
        Ui_ArtistHome arts = null;
        public void senderListener(Ui_ListenerHome home)
        {
            list = home;
        }

        public void senderArtist(Ui_ArtistHome home)
        {
            arts = home;
        }

        public void populateUpdate(string fn, string  ln, string gen, byte[] pc, string email, string passwd )
        {
            MemoryStream ms = new MemoryStream(pc);
            picUser.Image = Image.FromStream(ms);
            txtFname.Text = fn;
            txtLname.Text = ln;
            userEmail = email;
            userPasswd = passwd;
            if (gen.Equals("M"))
            {
                rbMale.Select();
            }
            else if (gen.Equals("F"))
            {
                rbFemale.Select();
            }
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (list != null)
            {
                int flag = 0;

                Listener user = new Listener();

                MemoryStream ms = new MemoryStream();
                picUser.Image.Save(ms, picUser.Image.RawFormat);
                user.picture = ms.ToArray();


                user.fName = txtFname.Text;
                user.lName = txtLname.Text;
                user.email = userEmail;
                
                if (rbMale.Checked)
                {
                    user.gender = "M";

                }
                else if (rbFemale.Checked)
                {
                    user.gender = "F";
                }
                else
                {
                    errGender.Visible = true;
                    flag = 1;
                }

                if (flag == 0)
                {
                    user.updateListener();
                    list.populateHome(userEmail,userPasswd);
                    this.Close();
                }
            }
            else if (arts != null)
            {
                int flag = 0;

                Artist user = new Artist();

                MemoryStream ms = new MemoryStream();
                picUser.Image.Save(ms, picUser.Image.RawFormat);
                user.picture = ms.ToArray();


                user.fName = txtFname.Text;
                user.lName = txtLname.Text;
                user.email = userEmail;

                if (rbMale.Checked)
                {
                    user.gender = "M";

                }
                else if (rbFemale.Checked)
                {
                    user.gender = "F";
                }
                else
                {
                    errGender.Visible = true;
                    flag = 1;
                }

                if (flag == 0)
                {
                    user.updateArtist();
                    arts.populateHome(userEmail, userPasswd);
                    this.Close();
                }
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
