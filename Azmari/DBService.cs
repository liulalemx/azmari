using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Azmari
{
    class DBService
    {
        string conStr = "server=.;database=AZMARI;uid=testuser;pwd=password;pooling=true; connection lifetime=120; max pool size=500";

        public int loginListener(string email, string password)
        {
            int error = 1;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspLoginListener", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Listener l = new Listener();
                        l.email = rdr["Email"].ToString();
                        l.password = rdr["Password"].ToString();
                        if (email.Equals(l.email) && password.Equals(l.password))
                        {
                            error = 0;
                        }        
                    }

                    rdr.Close();
                    con.Close();
                }

            }
            catch (SqlException)
            {
                error = 1;
            }

            return error;
        }

        public int loginArtist(string email, string password)
        {
            int error = 1;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspLoginArtist", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Artist a = new Artist();
                        a.email = rdr["Email"].ToString();
                        a.password = rdr["Password"].ToString();
                        if (email.Equals(a.email) && password.Equals(a.password))
                        {
                            error = 0;
                        }
                    }

                    rdr.Close();
                    con.Close();
                }

            }
            catch (SqlException)
            {
                error = 1;
            }

            return error;
        }

        public void saveListener(Listener lis)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspSignUpListener", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", lis.fName);
                cmd.Parameters.AddWithValue("@Lastname", lis.lName);
                cmd.Parameters.AddWithValue("@Gender", lis.gender);
                cmd.Parameters.AddWithValue("@Email", lis.email);
                cmd.Parameters.AddWithValue("@Password", lis.password);
                cmd.Parameters.AddWithValue("@Picture", lis.picture);
                cmd.Parameters.AddWithValue("@PrefrenceName1", lis.prefrence1);
                cmd.Parameters.AddWithValue("@PrefrenceName2", lis.prefrence2);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void saveArtist(Artist ars)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspSignUpArtist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", ars.fName);
                cmd.Parameters.AddWithValue("@Lastname", ars.lName);
                cmd.Parameters.AddWithValue("@Stagename", ars.stageName);
                cmd.Parameters.AddWithValue("@Gender", ars.gender);
                cmd.Parameters.AddWithValue("@Email", ars.email);
                cmd.Parameters.AddWithValue("@Password", ars.password);
                cmd.Parameters.AddWithValue("@Picture", ars.picture);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Listener populateHomeListener(string email, string password)
        {
            try
            {
                Listener l = new Listener();
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspPopulateListenerPage", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListenerEmail", email);
                    
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        l.fName = rdr["Firstname"].ToString();
                        l.lName = rdr["Lastname"].ToString();
                        l.gender = rdr["Gender"].ToString();
                        l.email = rdr["Email"].ToString();
                        l.password = rdr["Password"].ToString();
                        l.picture = (byte[])rdr["Picture"];
                    }
                    rdr.Close();
                    con.Close();
                }

                return l;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public Artist populateHomeArtist(string email, string password)
        {
            try
            {
                Artist a = new Artist();
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspGetArtistInfo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ArtistEmail", email);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        a.fName = rdr["Firstname"].ToString();
                        a.lName = rdr["Lastname"].ToString();
                        a.stageName = rdr["Stagename"].ToString();
                        a.gender = rdr["Gender"].ToString();
                        a.email = rdr["Email"].ToString();
                        a.password = rdr["Password"].ToString();
                        a.picture = (byte[])rdr["Picture"];
                        
                    }
                    rdr.Close();
                    con.Close();
                }

                return a;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void saveSong(Music mus)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspPublishMusic", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusicName",mus.musicName);
                cmd.Parameters.AddWithValue("@MusicFile", mus.musicFile);
                cmd.Parameters.AddWithValue("@Picture", mus.picture);
                cmd.Parameters.AddWithValue("@ArtistEmail", mus.artistEmail);
                cmd.Parameters.AddWithValue("@Genre", mus.genre);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<Music> getSongs(string email)
        {
            List<Music> lstSongs = new List<Music>();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspPopulateArtistPage", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ArtistEmail", email);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Music m = new Music();
                        m.musicName = rdr["MusicName"].ToString();
                        m.picture = (byte[])rdr["Picture"];
                        m.listeners = rdr["Listeners"].ToString();
                        m.musicFile = (byte[])rdr["MusicFile"];
                        lstSongs.Add(m);
                    }
                    rdr.Close();
                    con.Close();
                }

                return lstSongs;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<Music> getAllSongs()
        {
            List<Music> lstSongs = new List<Music>();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspGetAllSongs", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Music m = new Music();
                        m.musicName = rdr["MusicName"].ToString();
                        m.picture = (byte[])rdr["Picture"];
                        m.listeners = rdr["Listeners"].ToString();
                        m.musicFile = (byte[])rdr["MusicFile"];
                        m.stageName = rdr["Stagename"].ToString();
                        lstSongs.Add(m);
                    }
                    rdr.Close();
                    con.Close();
                }

                return lstSongs;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public byte[] playMusic(string listEmail, string musName)
        {
            byte[] song = null;
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspListenerPlaysMusic", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ListenerEmail", listEmail);
                    cmd.Parameters.AddWithValue("@MusicName", musName);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        song = (byte[])rdr["MusicFile"];
                        
                    }
                    rdr.Close();                         
                    con.Close();
                }

                return song;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public void updateListener(Listener lis)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspUpdateListener", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", lis.fName);
                cmd.Parameters.AddWithValue("@Lastname", lis.lName);
                cmd.Parameters.AddWithValue("@Gender", lis.gender);
                cmd.Parameters.AddWithValue("@Email", lis.email);
                cmd.Parameters.AddWithValue("@Picture", lis.picture);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void updateArtist(Artist art)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspUpdateArtist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", art.fName);
                cmd.Parameters.AddWithValue("@Lastname", art.lName);
                cmd.Parameters.AddWithValue("@Gender", art.gender);
                cmd.Parameters.AddWithValue("@Email", art.email);
                cmd.Parameters.AddWithValue("@Picture", art.picture);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void deleteSong(string mName)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("uspDeleteSong", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MusicName", mName);
                
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public DataTable getInfoForReport(string email)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspGenerateArtistReport", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ArtistEmail", email);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    rdr.Close();
                    con.Close();
                }

                return dt;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        public List<Artist> getArts(string fname, string lname, string email)
        {
            List<Artist> lstArt = new List<Artist>();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                SqlCommand cmd = new SqlCommand("uspSearchArtist", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Fname", fname);
                cmd.Parameters.AddWithValue("@Lname", lname);
                cmd.Parameters.AddWithValue("@Email", email);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Artist e = new Artist();
                    e.fName = rdr["Firstname"].ToString();
                    e.lName = rdr["Lastname"].ToString();
                    e.stageName = rdr["Stagename"].ToString();
                    e.picture = (byte[])rdr["Picture"];
                    e.email = rdr["Email"].ToString();
                    lstArt.Add(e);
                }
                rdr.Close();
                con.Close();
            }

            return lstArt;
        }

        public List<Music> getArtistSong(string email)
        {
            List<Music> lstSongs = new List<Music>();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("uspGetArtistSongs", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Music m = new Music();
                        m.musicName = rdr["MusicName"].ToString();
                        m.picture = (byte[])rdr["Picture"];
                        m.listeners = rdr["Listeners"].ToString();
                        m.musicFile = (byte[])rdr["MusicFile"];
                        m.stageName = rdr["Stagename"].ToString();
                        lstSongs.Add(m);
                    }
                    rdr.Close();
                    con.Close();
                }

                return lstSongs;
            }
            catch (SqlException)
            {
                throw;
            }
        }

    }
}
