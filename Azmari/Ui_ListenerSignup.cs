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
    public partial class Ui_ListenerSignup : Form
    {
        public Ui_ListenerSignup()
        {
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "choose Photo (*.jpg; *.png; *.Jpeg; *.bmp;) | *.jpg; *.png; *.Jpeg; *.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picUser.Image = Image.FromFile(op.FileName);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            int flag = 0;

            Listener user = new Listener();

            MemoryStream ms = new MemoryStream();
            picUser.Image.Save(ms, picUser.Image.RawFormat);
            user.picture = ms.ToArray();
                     
            
            user.fName = txtFname.Text;
            user.lName = txtLname.Text;
            user.email = txtEmail.Text;
            user.password = txtPasswd.Text;

            if (!string.IsNullOrEmpty(cmbG1.Text))
            {
                user.prefrence1 = cmbG1.Text;
      
            }
            else
            {
                errGenre.Visible = true; 
            }
                
            if (!string.IsNullOrEmpty(cmbG2.Text))
            {
                user.prefrence2 = cmbG2.Text;
            }
            else
            {
                errGenre.Visible = true;
            }

            if (rbMale.Checked)
            {
                user.gender = "M";

            }
            else if(rbFemale.Checked)
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
                user.saveListener();
                Ui_UserLogin login = new Ui_UserLogin();
                login.Show();
                this.Close();
            }
        }

        private void Ui_ListenerSignup_Load(object sender, EventArgs e)
        {
            errGender.Visible = false;
            errGenre.Visible = false;
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
    }
    
}
