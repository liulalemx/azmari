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
using System.Media;

namespace Azmari
{
    public partial class Ui_ListenerHome : Form
    {
        public Ui_ListenerHome()
        {
            InitializeComponent();
        }

        private void Ui_ListenerHome_Load(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Transparent;
            lblArtist.BackColor = Color.Transparent;
            lblSong.BackColor = Color.Transparent;
            lblUser.BackColor = Color.Transparent;
            getTracks();
        }

        Listener listener;
        public string listenerEmail;
        internal void populateHome(string email, string passwd)
        {
            Listener user = new Listener();
            listener = user.populateHome(email,passwd);
            lblUser.Text = listener.fName;
            MemoryStream ms = new MemoryStream(listener.picture);
            pbUser.Image = Image.FromStream(ms);
            listenerEmail = listener.email;
        }

        List<Music> songs = null;

        public object mStrm { get; private set; }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void getTracks()
        {
            Music music = new Music();
            songs = music.getAllSongs();

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
                dataMusic[2, row].Value = mu.stageName;
                dataMusic[3, row].Value = mu.listeners;
                row++;
            }


        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        bool loop = false;
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            Music msc = new Music();
            string musicName = dataMusic.CurrentRow.Cells[1].Value.ToString();
            string artistName = dataMusic.CurrentRow.Cells[2].Value.ToString();
            byte[] file = msc.playMusic(listenerEmail, musicName);
            MemoryStream ms = new MemoryStream((byte[])dataMusic.CurrentRow.Cells[0].Value);
            MemoryStream mss = new MemoryStream(file);

            SoundPlayer mySoundPlay = new SoundPlayer(mss);
            if (loop)
            {
                mySoundPlay.PlayLooping();
            }
            else
            {
                mySoundPlay.Play();
            }

            lblSong.Text = musicName;
            lblArtist.Text = artistName;
            picSong.Image = Image.FromStream(ms);
          
        }

        bool mouseFlag = false;
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

        private void BunifuGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseFlag = false;
        }

        private void BtnLoop_Click(object sender, EventArgs e)
        {
            if (loop)
            {
                loop = false;
                btnLoopActive.Visible = false;
            }
            else
            {
                loop = true;
                btnLoopActive.Visible = true;
            }
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            Ui_UserUpdate update = new Ui_UserUpdate();
            update.senderListener(this);
            update.populateUpdate(listener.fName, listener.lName, listener.gender, listener.picture, listener.email, listener.password);
            update.Show();
        }

        private void BtnArtSearch_Click(object sender, EventArgs e)
        {
            Ui_ListenerSearch search = new Ui_ListenerSearch();
            search.home = this;
            search.Show();
        }

       
        List<Music> musika = null;
        public void searchResult(string searchEmail)
        {
            dataMusic.Rows.Clear();
            Music musics = new Music();
            musika = musics.getArtistSongs(searchEmail);

            int row = 0;

            foreach (Music mu in musika)
            {
                dataMusic.Rows.Add(1);
                dataMusic[0, row].Value = mu.picture;
                dataMusic[1, row].Value = mu.musicName;
                dataMusic[2, row].Value = mu.stageName;
                dataMusic[3, row].Value = mu.listeners;
                row++;
            }
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            getTracks();
        }
    }
}
