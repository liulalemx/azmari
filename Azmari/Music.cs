using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azmari
{
    class Music
    {
        public string musicName;
        public string genre;
        public string artistEmail;
        public string stageName;
        public string listeners;
        public byte[] musicFile;
        public byte[] picture;

        public void saveSong()
        {
            DBService dbs = new DBService();
            dbs.saveSong(this);
        }

        public List<Music> getSongs(string artistEmail)
        {
            DBService dbs = new DBService();
            return dbs.getSongs(artistEmail);
        }

        public List<Music> getAllSongs()
        {
            DBService dbs = new DBService();
            return dbs.getAllSongs();
        }

        public byte[] playMusic(string listEmail,string musName)
        {
            DBService dbs = new DBService();
            return dbs.playMusic(listEmail, musName);
        }

        public void deleteSong(string name)
        {
            DBService dbs = new DBService();
            dbs.deleteSong(name);
        }

        public List<Music> getArtistSongs(string email)
        {
            DBService dbs = new DBService();
            return dbs.getArtistSong(email);
        }
    }
}
