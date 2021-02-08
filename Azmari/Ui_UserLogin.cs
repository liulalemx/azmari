using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azmari
{
    public partial class Ui_UserLogin : Form
    {
        public Ui_UserLogin()
        {
            InitializeComponent();
                    
        }

        private void Ui_Login_Load(object sender, EventArgs e)
        {
            PictureBox pbBg = pbBackground;
            pbBg.Controls.Add(pbIcon);
            pbBg.Controls.Add(pbCenterIcon);
            pbBg.Controls.Add(lblName);
            pbBg.Controls.Add(lblAboutUs);
            pbBg.Controls.Add(lblPrivacyPolicy);
            pbBg.Controls.Add(lblTermsOfUse);
            pbBg.Controls.Add(lblCopyright);
            pbBg.Controls.Add(lblSignUp);
            pbBg.Controls.Add(txtEmail);
            pbBg.Controls.Add(txtPassword);
            pbBg.Controls.Add(btnLogin);
            pbBg.Controls.Add(btnClose);
            pbBg.Controls.Add(btnClose);
            pbBg.Controls.Add(errEmail);
            pbBg.Controls.Add(errPassword);
            pbBg.Controls.Add(lblArtist);
            

            pbIcon.BackColor = Color.Transparent;
            pbCenterIcon.BackColor = Color.Transparent;
            lblName.BackColor = Color.Transparent;
            lblAboutUs.BackColor = Color.Transparent;
            lblPrivacyPolicy.BackColor = Color.Transparent;
            lblTermsOfUse.BackColor = Color.Transparent;
            lblCopyright.BackColor = Color.Transparent;
            lblSignUp.BackColor = Color.Transparent;
            btnLogin.BackColor = Color.Transparent;
            btnClose.BackColor = Color.Transparent;
            btnClose.BackColor = Color.Transparent;
            errEmail.BackColor = Color.Transparent;
            errPassword.BackColor = Color.Transparent;
            lblArtist.BackColor = Color.Transparent;
            
            foreach (Control item in pbBg.Controls)
            {
                if (item.GetType().Name.CompareTo("PictureBox") == 0)
                {
                    PictureBox pic = (PictureBox)item;
                    if (pic.Name.StartsWith("err"))
                    {
                        pic.Visible = false;
                    }
                }
            }

           
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        Listener user = new Listener();
        Artist creator = new Artist();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string email="", passwd="";

            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                email = txtEmail.Text;
            }
            else
            {
                flag = 1;
                errEmail.Visible = true;
            }

            if (!string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                passwd = txtPassword.Text;
            }
            else
            {
                flag = 1;
                errPassword.Visible = true;
            }

            if (flag == 0)
            {
                if (!chkArtist.Checked)
                {
                    if (user.loginListener(email,passwd) == 0)
                    {
                        errEmail.Visible = false;
                        errPassword.Visible = false;
                        Ui_ListenerHome home = new Ui_ListenerHome();
                        home.populateHome(email,passwd);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        errEmail.Visible = true;
                        errPassword.Visible = true;
                    }
                }
                else
                {
                    if (creator.loginArtist(email, passwd) == 0)
                    {
                        errEmail.Visible = false;
                        errPassword.Visible = false;
                        Ui_ArtistHome home = new Ui_ArtistHome();
                        home.populateHome(email, passwd);
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        errEmail.Visible = true;
                        errPassword.Visible = true;
                    }
                }
              
                           
            }
        }

        private void LblSignUp_Click(object sender, EventArgs e)
        {
            if (chkArtist.Checked)
            {
                Ui_ArtistSignup signup = new Ui_ArtistSignup();
                signup.Show();
                this.Hide();
            }
            else
            {
                Ui_ListenerSignup signup = new Ui_ListenerSignup();
                signup.Show();
                this.Hide();

            }
        }

        bool mouseFlag = false;

        private void PbBackground_MouseDown(object sender, MouseEventArgs e)
        {
            mouseFlag = true;
        }

        private void PbBackground_MouseUp(object sender, MouseEventArgs e)
        {
            mouseFlag = false;
        }

        private void PbBackground_MouseMove(object sender, MouseEventArgs e)
        {
             if (mouseFlag == true)

            {
                this.Location = Cursor.Position;
            }
        }

        private void BunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
