using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azmari
{
    class Listener
    {
        public string fName;
        public string lName;
        public string gender;
        public string email;
        public string password;
        public byte[] picture;
        public string prefrence1;
        public string prefrence2;

        public int loginListener(string email, string password)
        {
            DBService dbs = new DBService();
            return dbs.loginListener(email,password);
        }

        public void saveListener()
        {
            DBService dbs = new DBService();
            dbs.saveListener(this);
        }

        public Listener populateHome(string email, string password)
        {
            DBService dbs = new DBService();
            return dbs.populateHomeListener(email,password);
        }

        public void updateListener()
        {
            DBService dbs = new DBService();
            dbs.updateListener(this);
        }
    }
}
