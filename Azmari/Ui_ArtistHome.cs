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
    public partial class Ui_ArtistHome : Form
    {
        public Ui_ArtistHome()
        {
            InitializeComponent();
        }

        Artist artist;
        string artistEmail;
        private void UiArtistHome_Load(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Transparent;
            lblUser.BackColor = Color.Transparent;
            getTracks();
        }

        internal void populateHome(string email, string passwd)
        {
            Artist user = new Artist();
            artist = user.populateHome(email, passwd);
            lblUser.Text = artist.stageName;
            MemoryStream ms = new MemoryStream(artist.picture);
            pbUser.Image = Image.FromStream(ms);

            artistEmail = artist.email;
        }

        private void BtnPublish_Click(object sender, EventArgs e)
        {
            Ui_ArtistPublish publish = new Ui_ArtistPublish();
            publish.setArtistEmail(artistEmail);
            publish.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            Ui_ArtistReport report = new Ui_ArtistReport();
            report.Email = artistEmail;
            report.Show();
        }

        List<Music> songs = null;
        public void getTracks()
        {
            Music music = new Music();
            songs = music.getSongs(artistEmail);
            
            int row = 0;

            if (dataMusic.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dataMusic.Rows)
                {
                    dataMusic.Rows.Remove(item);
                }
            }

            foreach (Music mu in songs)
            {
                dataMusic.Rows.Add(1);
                dataMusic[0, row].Value = mu.picture;
                dataMusic[1, row].Value = mu.musicName;
                dataMusic[2, row].Value = artistEmail;
                dataMusic[3, row].Value = mu.listeners;
                row++;
            }


        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            getTracks();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool mouseFlag = false;
        private void BunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseFlag = false;
        }

        private void BunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseFlag == true)

            {
                this.Location = Cursor.Position;
            }
        }

        private void BunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseFlag = true;
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            Ui_UserUpdate update = new Ui_UserUpdate();
            update.senderArtist(this);
            update.populateUpdate(artist.fName, artist.lName, artist.gender, artist.picture, artist.email, artist.password);
            update.Show();
        }

        private void BtnDeleteSong_Click(object sender, EventArgs e)
        {
            string musicName = dataMusic.CurrentRow.Cells[1].Value.ToString();
            Music song = new Music();
            song.deleteSong(musicName);
            getTracks();
        }
    }
}
