using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace Test
{
    public class Videos
    {
       
        public  string id {get;set;}
        public  string accountid {get;set;}
        public  DateTime creationdate {get;set;}
        public  DateTime enddate {get;set;}
        public  string flvurl {get;set;}
        public  string itemstate {get;set;}
        public  DateTime lastmodified {get;set;}
        public  string length {get;set;}
        public  string linktext {get;set;}
        public  string linkurl {get;set;}
        public  string longdescription {get;set;}
        public  string name {get;set;}
        public  int playstotal {get;set;}
        public  int playstrailingweek {get;set;}
        public  DateTime publishdate {get;set;}
        public  string referenceid {get;set;}
        public  string shortdescription {get;set;}
        public  DateTime startdate {get;set;}
        public  string thumbnailurl {get;set;}
        public  string videostillurl { get; set; }

        //public static string VideoURL = "http://new.primeforlife.org/Content/Videos/";
        //public static string ThumbBaseURL = "http://www.primeforlife.org/modules/OnlineManual/";

        protected static string CON_STRING = @"Data Source=192.168.251.101\PRIWeb;Initial Catalog=askpri;Persist Security Info=True;User ID=ops;Password=PRI24web";
        protected static string Q_SELECT_ALL = @"select * from [askpri].[dbo].[Videos_BC]";
        protected static string Q_DELETE_ALL = @"delete from [askpri].[dbo].[Videos_BC]";
        protected static string Q_SELECT_BY_VIDEO_ID = @"select * from [askpri].[dbo].[Videos_BC] where videoid = {0}";
        protected static string Q_UPDATE_BY_VIDEO_ID =
@"UPDATE [askpri].[dbo].[Videos_BC]
   SET 
       [accountid] = {0}
      ,[creationdate] = '{1}'
      ,[enddate] = '{2}'
      ,[flvurl] = '{3}'
      ,[itemstate] = '{4}'
      ,[lastmodified] = '{5}'
      ,[length] = '{6}'
      ,[linktext] = '{7}'
      ,[linkurl] = '{8}'
      ,[longdescription] = '{9}'
      ,[name] = '{10}'
      ,[playstotal] = {11}
      ,[playstrailingweek] = {12}
      ,[publishdate] = '{13}'
      ,[referenceid] = '{14}'
      ,[shortdescription] = '{15}'
      ,[thumbnailurl] = '{16}'
      ,[videostillurl] = '{17}'
 WHERE [id] = '{18}'";

        protected static string Q_INSERT = @"INSERT INTO [askpri].[dbo].[Videos_BC]
           ([id]
           ,[accountid]
           ,[creationdate]
           ,[enddate]
           ,[flvurl]
           ,[itemstate]
           ,[lastmodified]
           ,[length]
           ,[linktext]
           ,[linkurl]
           ,[longdescription]
           ,[name]
           ,[playstotal]
           ,[playstrailingweek]
           ,[publishdate]
           ,[referenceid]
           ,[shortdescription]
           ,[thumbnailurl]
           ,[videostillurl])
     VALUES
           ('{0}' 
           ,'{1}' 
           ,'{2}' 
           ,'{3}'
           ,'{4}'
           ,'{5}'
           ,'{6}'
           ,'{7}'
           ,'{8}'
           ,'{9}'
           ,'{10}'
           ,'{11}'
           ,{12}
           ,{13}
           ,'{14}'
           ,'{15}'
           ,'{16}'
           ,'{17}'
           ,'{18}')";

         

        /*
         * SELECT [id]
      ,[accountid]
      ,[creationdate]
      ,[enddate]
      ,[flvurl]
      ,[itemstate]
      ,[lastmodified]
      ,[length]
      ,[linktext]
      ,[linkurl]
      ,[longdescription]
      ,[name]
      ,[playstotal]
      ,[playstrailingweek]
      ,[publishdate]
      ,[referenceid]
      ,[shortdescription]
      ,[thumbnailurl]
      ,[videosurl]
  FROM [askpri].[dbo].[Videos_BC]
         * */

        public Videos()
        {
        }

        /*public string GetMP4Link()
        {
            return Videos.VideoURL + Path.GetFileNameWithoutExtension(filename) + ".mp4";
        }
        public string GetOGGLink()
        {
            return Videos.VideoURL + Path.GetFileNameWithoutExtension(filename) + ".ogg";
        }*/

        private static SqlConnection GetDBConnection()
        {
            SqlConnection m_conn = null;
            m_conn = new SqlConnection(CON_STRING);
            return m_conn;
        }

        public static List<Videos> LoadFromDataReader(SqlDataReader m_rdr)
        {
            List<Videos> videos = new List<Videos>();
            while (m_rdr.Read())
            {
                Videos v = new Videos();
                if (!DBNull.Value.Equals(m_rdr["videostillurl"]))
                    v.videostillurl = m_rdr["videostillurl"].ToString();
                if (!DBNull.Value.Equals(m_rdr["thumbnailurl"]))
                    v.thumbnailurl = m_rdr["thumbnailurl"].ToString();
                if (!DBNull.Value.Equals(m_rdr["shortdescription"]))
                    v.shortdescription = m_rdr["shortdescription"].ToString();
                if (!DBNull.Value.Equals(m_rdr["referenceid"]))
                    v.referenceid = m_rdr["referenceid"].ToString();
                if (!DBNull.Value.Equals(m_rdr["publishdate"]))
                    v.publishdate = Convert.ToDateTime(m_rdr["publishdate"]);
                if (!DBNull.Value.Equals(m_rdr["id"]))
                    v.id = m_rdr["id"].ToString();
                if (!DBNull.Value.Equals(m_rdr["accountid"]))
                    v.accountid = m_rdr["accountid"].ToString();
                if (!DBNull.Value.Equals(m_rdr["creationdate"]))
                    v.creationdate = Convert.ToDateTime(m_rdr["creationdate"]);
                if (!DBNull.Value.Equals(m_rdr["enddate"]))
                    v.enddate = Convert.ToDateTime(m_rdr["enddate"]);
                if (!DBNull.Value.Equals(m_rdr["flvurl"]))
                    v.flvurl = m_rdr["flvurl"].ToString();
                if (!DBNull.Value.Equals(m_rdr["itemstate"]))
                    v.itemstate = m_rdr["itemstate"].ToString();
                if (!DBNull.Value.Equals(m_rdr["lastmodified"]))
                    v.lastmodified = Convert.ToDateTime(m_rdr["lastmodified"]);
                if (!DBNull.Value.Equals(m_rdr["length"]))
                    v.length = m_rdr["length"].ToString();
                if (!DBNull.Value.Equals(m_rdr["linktext"]))
                    v.linktext = m_rdr["linktext"].ToString();
                if (!DBNull.Value.Equals(m_rdr["linkurl"]))
                    v.linkurl = m_rdr["linkurl"].ToString();
                if (!DBNull.Value.Equals(m_rdr["longdescription"]))
                    v.longdescription = m_rdr["longdescription"].ToString();
                if (!DBNull.Value.Equals(m_rdr["name"]))
                    v.name = m_rdr["name"].ToString();
                if (!DBNull.Value.Equals(m_rdr["playstotal"]))
                    v.playstotal = Convert.ToInt32(m_rdr["playstotal"]);
                if (!DBNull.Value.Equals(m_rdr["playstrailingweek"]))
                    v.playstotal = Convert.ToInt32(m_rdr["playstrailingweek"]);
                
                videos.Add(v);

            }
            return videos;
        }
        public static int NonQuery(string query)
        {
            SqlConnection m_conn = GetDBConnection();
            m_conn.Open();

            SqlCommand updateCmd = new SqlCommand(query, m_conn);
            int rowsAffected = updateCmd.ExecuteNonQuery();
            // 5. Close the connection
            if (m_conn != null)
            {
                m_conn.Close();
            }
            return rowsAffected;

        }

      
        public static List<Videos> GetByQuery(string query)
        {
            SqlConnection m_conn = GetDBConnection();
            m_conn.Open();
            SqlCommand cmd = new SqlCommand(query, m_conn);
            SqlDataReader m_rdr = cmd.ExecuteReader();

            List<Videos> videos = LoadFromDataReader(m_rdr);

            // close the reader
            if (m_rdr != null)
            {
                m_rdr.Close();
            }

            // 5. Close the connection
            if (m_conn != null)
            {
                m_conn.Close();
            }
            return videos;
        }

        public static void DeleteAll()
        {
             NonQuery(Q_DELETE_ALL);
        }

        public static List<Videos> GetAllVideos()
        {
            return GetByQuery(Q_SELECT_ALL);
        }

        public static Videos GetVideoByID(int videoid)
        {
            List<Videos> videos = GetByQuery(String.Format(Q_SELECT_BY_VIDEO_ID, videoid));
            return videos[0];
        }

        /*public static int Update(Videos v)
        {
            v.changed = DateTime.Now;
            return UpdateByQuery(String.Format(Q_UPDATE_BY_VIDEO_ID.Replace("\r\n", ""),
                     v.authorid, v.title, v.URI, v.description,
                    v.thumbnail, v.created, v.changed, v.allow_public, v.statusid,
                    v.bcvideoid, v.filename, v.old_URI, v.base_url, v.videoid));
        }*/

        /*([id]
           ,[accountid]
           ,[creationdate]
           ,[enddate]
           ,[flvurl]
           ,[itemstate]
           ,[lastmodified]
           ,[length]
           ,[linktext]
           ,[linkurl]
           ,[longdescription]
           ,[name]
           ,[playstotal]
           ,[playstrailingweek]
           ,[publishdate]
           ,[referenceid]
           ,[shortdescription]
           ,[thumbnailurl]
           ,[videostillurl])*/
        public static int Insert(Videos video)
        {
            return NonQuery(String.Format(Q_INSERT.Replace("\r\n", ""), video.id, video.accountid,
                video.creationdate, video.enddate, video.flvurl, video.itemstate, video.lastmodified,
                video.length, video.linktext, video.linkurl, video.longdescription, video.name, video.playstotal,
                video.playstrailingweek, video.publishdate, video.referenceid, video.shortdescription, video.thumbnailurl,
                video.videostillurl));
        }



    }
}
