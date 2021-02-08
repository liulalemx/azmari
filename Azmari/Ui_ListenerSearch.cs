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
    public partial class Ui_ListenerSearch : Form
    {
        public Ui_ListenerSearch()
        {
            InitializeComponent();
        }

        private void Ui_ListenerSearch_Load(object sender, EventArgs e)
        {
            lblSearch.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;
            lblFname.BackColor = Color.Transparent;
            lblLname.BackColor = Color.Transparent;

        }
        List<Artist> lstArt = null;
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Artist artModel = new Artist();
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string email = txtEmail.Text;

            lstArt = artModel.getArts(fname, lname, email);

            int row = 0;

            if (dataMusic.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dataMusic.Rows)
                {
                    dataMusic.Rows.Remove(item);
                }
            }

            foreach (Artist ar in lstArt)
            {
                dataMusic.Rows.Add(1);
                dataMusic[0, row].Value = ar.picture;
                dataMusic[1, row].Value = ar.fName;
                dataMusic[2, row].Value = ar.lName;
                dataMusic[3, row].Value = ar.stageName;
                dataMusic[4, row].Value = ar.email;
                row++;
            }
        }

        public Ui_ListenerHome home;

        public string aEmail;
        private void BtnLoadSongs_Click(object sender, EventArgs e)
        {
            aEmail = dataMusic.CurrentRow.Cells[4].Value.ToString();
            home.searchResult(aEmail);
            this.Close();
        }
    }
}
