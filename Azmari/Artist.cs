using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azmari
{
    class Artist
    {
        public string fName;
        public string lName;
        public string stageName;
        public string gender;
        public string email;
        public string password;
        public byte[] picture;

        public int loginArtist(string email, string password)
        {
            DBService dbs = new DBService();
            return dbs.loginArtist(email, password);
        }

        public void saveArtist()
        {
            DBService dbs = new DBService();
            dbs.saveArtist(this);
        }

        public Artist populateHome(string email, string password)
        {
            DBService dbs = new DBService();
            return dbs.populateHomeArtist(email, password);
        }

        public void updateArtist()
        {
            DBService dbs = new DBService();
            dbs.updateArtist(this);
        }

        public List<Artist> getArts(string fname, string lname, string email)
        {
            DBService dbs = new DBService();
            List<Artist> lstArt = dbs.getArts(fname, lname, email);
            return lstArt;
        }
    }
}
