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
    public partial class Ui_ArtistPublish : Form
    {
        public Ui_ArtistPublish()
        {
            InitializeComponent();
        }

        private void Ui_ArtistPublish_Load(object sender, EventArgs e)
        {
            lblHome.BackColor = Color.Transparent;
        }

        string fileLocation;
        string artistEmail;

        public void setArtistEmail(string email)
        {
            artistEmail = email;
        }

        private void PicSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter ="All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV"; ;
            if (op.ShowDialog() == DialogResult.OK)
            {
                fileLocation = op.FileName;
            }
        }

        private void BtnPublish_Click(object sender, EventArgs e)
        {
            int flag = 0;

            Music song = new Music();

            MemoryStream ms = new MemoryStream();
            picSongCover.Image.Save(ms, picSongCover.Image.RawFormat);
            song.picture = ms.ToArray();

            song.musicFile = File.ReadAllBytes(fileLocation);

            song.musicName = txtSongname.Text;
            song.genre = cmbGenre.Text;
            song.artistEmail = artistEmail;

            if (flag == 0)
            {
                song.saveSong();
                MessageBox.Show("Song published successfully!");
                this.Close();
            }

        }

        private void PicSongCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "choose Photo (*.jpg; *.png; *.Jpeg; *.bmp;) | *.jpg; *.png; *.Jpeg; *.bmp;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                picSongCover.Image = Image.FromFile(op.FileName);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
