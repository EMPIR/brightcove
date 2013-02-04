using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using BrightcoveMapiWrapper.Api;
using BrightcoveMapiWrapper.Model;
using BrightcoveMapiWrapper.Model.Containers;
using BrightcoveMapiWrapper.Model.Items;
using System.IO;
using System.Net;

using BroccoliProducts;
using BroccoliProducts.LowLevel;

namespace Test
{
    class Program
    {
        public static string IDs = @"773785141001,
776286637001,
1483692315001,
1441513181001,
742822831001,
1483685453001,
738314963001,
802437595001,
1695924039001,
738315001001,
739504498001,
1518984842001,
739504497001,
1695913615001,
1466574058001,
771768371001,
780927240001,
1561023710001,
749656022001,
739508821001,
1502831341001,
749738012001,
1463325960001,
1490048165001,
1456756738001,
1695950806001,
1483692310001,
1443607198001,
772659715001,
1456743627001,
1441513192001,
1450519919001,
1450519935001,
1695938994001,
1456743617001,
738314966001,
744821773001,
761114541001,
1481230955001,
1695938980001,
782283552001,
1463356506001,
738305094001,
822945531001,
1695881199001,
763047655001,
742650962001,
1452873329001,
1455051004001,
1452873372001,
810974999001,
1483740510001,
1428361148001,
738305124001,
1483692319001,
1452951265001,
749737979001,
744402076001,
763098834001,
781163223001,
1695950813001,
1560922958001,
810394067001,
738305087001,
777446452001,
1437275570001,
1483733150001,
763304682001,
817511020001,
820217148001,
739498743001,
738359112001,
1483685448001,
749732231001,
738305112001,
739498738001,
1467137368001,
1477541102001,
1510693835001,
1510634871001,
1530808518001,
1483740523001,
1514222033001,
1455050994001,
1483685439001,
749732266001,
1481193469001,
756523366001,
1481227030001,
1531130608001,
739437603001,
1481503357001,
781097683001,
1481193478001,
739437601001,
1463347848001,
738305146001,
1483679483001,
746598210001,
1511103467001,
1428412507001,
1532717118001,
1530755175001,
738433063001,
738315013001,
1532923203001,
1481473945001,
739424301001,
1443567493001,
1537528479001,
739424300001,
1429937805001,
1481473950001,
739427224001,
791374667001,
1483328549001,
1507677819001,
791365602001,
738412498001,
1534895815001,
1477577691001,
759866749001,
1455053821001,
1507666641001,
1502812895001,
1471820964001,
738412502001,
760202259001,
1450519923001,
1533031228001,
1514251503001,
1553886347001,
,1502809677001,
1537539665001,
812524852001,
1456756736001,
749732250001,
772636658001,
1428414439001,
1428414423001,
1452873304001,
1519075040001,
1428323205001,
1452895241001,
1477595495001,
1463356513001,
1537505482001,
742650964001,
739464152001,
1531719659001,
777666858001,
1452911462001,
1452873318001,
738412497001,
798456122001,
1544039616001,
1511128988001,
1437303071001,
1483740514001,
777666862001,
1520998530001,
798434255001,
757886657001,
1428412502001,
777730831001,
739437602001,
774908274001,
797680898001,
1536862940001,
1456711852001,
1464909572001,
777730833001,
755217063001,
1510693824001,
760402189001,
812919107001,
1507831441001,
1443575666001,
1467137386001,
1544048452001,
1456378626001,
1496526672001,
738305081001,
1544044153001,
738465647001,
1514227878001,
818613120001,
1428361129001,
1477595497001,
746853680001,
822945525001,
1483309811001,
1456378621001,
761307056001,
810575292001,
1507657866001,
746853678001,
821406628001,
1537006098001,
791374954001,
771487588001,
760720589001,
779872734001,
798465140001,
746918676001,
791365596001,
810607599001,
1537130446001,
798498792001,
798498797001,
810588615001,
760706669001,
798497091001,
738342337001,
820280293001,
760720621001,
755905400001,
793851978001,
755914567001,
755914566001,
792516126001,
755938163001,
810588613001,
777730826001,
821197826001,
744617366001,
827213904001,
790583791001,
756493122001,
739427221001,
1533240860001,
1477541066001,
753114378001,
750375680001,
767842655001,
818961189001,
775136428001,
1507831872001,
744785549001,
822751217001,
820184734001,
821236768001,
1558808562001,
760706670001,
790455331001,
1481230968001,
794133943001,
821197852001,
820412038001,
818961486001,
772636655001,
819943198001,
818961488001,
822945498001,
818961493001,
738305097001,
814372547001,
782295323001,
1559360737001,
782283543001,
1533260341001,
798456165001,
1508123189001,
820182821001,
791365546001,
817443715001,
826023239001,
819060508001,
748334554001,
748446851001,
763052180001,
776377785001,
821417099001,
818961494001,
818690392001,
1560964863001,
820184736001,
748437551001,
1550734628001,
821399070001,
808084903001,
820217070001,
755905398001,
760615857001,
817443316001,
738342350001,
825996654001,
812702403001,
775105992001,
818961133001,
1544044118001,
782544078001,
1559058019001,
1526556322001,
1544408361001,
818961489001,
778801961001,
818961190001,
1545567916001,
1481230964001,
806840967001,
1554079965001,
1537539672001,
755938158001,
738314951001,
1467112355001,
819943243001,
1481230970001,
1540444458001,
1526556352001,
1532650632001,
818548816001,
738412504001,
1538785979001,
1519073617001,
755938161001,
1547306061001,
1450519970001,
746369866001,
1544044098001,
1543704577001,
1519073621001,
777667674001,
1526786234001,
1557029343001,
763304681001,
1481227056001,
738433030001,
782283539001,
1538785981001,
1502809675001,
1463356512001,
1543723670001,
1511128989001,
776286662001,
1532994241001,
1540444480001,
1519075038001,
1467194488001,
1477577690001,
1526595960001,
1452895272001,
776459139001,
1544048472001,
1511103462001,
1526521910001,
1511128991001,
755938153001,
1483692317001,
760720618001,
1544044134001,
748621411001,
1502688390001,
1507831502001,
1463347836001,
820057156001,
1452895212001,
776409831001,
845645370001,
1441526200001,
810588614001,
738744834001,
777666865001,
1514222036001,
1519075037001,
1519075031001,
1450519953001,
1540444478001,
1492332889001,
1514251517001,
1507950224001,
1508125129001,
1519737692001,
1544039573001,
1511363373001,
810575295001,
814457708001,
1514222031001,
,1533028524001,
1511127734001,
1443567486001,
738436464001,
776459140001,
810271546001,
798513694001,
1502809678001,
755938164001,
1513434931001,
1534932514001,
761250231001,
738291106001,
1511103460001,
1456711856001,
818640249001,
1534799754001,
1514222041001,
1553875099001,
1502831340001,
1507831436001,
819980425001,
827372085001,
1532910089001,
738433031001,
820111238001,
1463325962001,
819943197001,
1483740521001,
799731670001,
778792124001,
738433059001,
738436500001,
834932935001,
738431242001,
738436498001,
763675189001,
1532910081001,
819903068001,
1536984346001,
1526521973001,
760622461001,
1511103468001,
753330000001,
821406638001,
756528986001,
738346853001,
738436467001,
766801792001,
738346772001,
754411258001,
806643353001,
772269084001,
819943203001,
821357260001,
817475072001,
760565542001,
1560926575001,
755099427001,
820280290001,
822873613001,
746406948001,
791702404001,
777401350001,
782446809001,
756523369001,
738359089001,
753362436001,
821417107001,
820184718001,
821406617001,
755132167001,
738305102001,
744205407001,
754411254001,
738313149001,
1526593743001,
738313154001,
818951496001,
790210591001,
806870660001,
738433091001,
819986910001,
818961192001,
798418322001,
855897819001,
820184714001,
777279839001,
743217885001,
777730835001,
819912042001,
792516124001,
818781144001,
739498744001,
821417097001,
738305101001,
739616281001,
818951462001,
,738431214001,
746406949001,
799950300001,
738314965001,
746406919001,
819903085001,
738433062001,
820182800001,
820182808001,
818961193001,
808087631001,
738431236001,
760720641001,
738431223001,
738287475001,
772425613001,
738314959001,
738342320001,
1531066902001,
738431240001,
738431237001,
738342401001,
760706657001,
778783624001,
739424296001,
820280296001,
739598846001,
756527902001,
754372288001,
819903063001,
745649534001,
739602064001,
738346770001,
738305095001,
738433028001,
818961181001,
738436461001,
1456743631001,
738436466001,
836502408001,
818961485001,
754387886001,
738412507001,
820220093001,
820217059001,
738436462001,
738696923001,
773739149001,
738313168001,
763047651001,
738313223001,
738314968001,
738313180001,
750997527001,
761307061001,
821399162001,
778783627001,
810575293001,
738431215001,
738431221001,
738433018001,
738431212001,
738313141001,
738412505001,
738315029001,
738431213001,
810607600001,
763052183001,
738431241001,
820057139001,
782446808001,
738313148001,
818613136001,
777085976001,
1511103471001,
739616300001,
1560928300001,
818776307001,
738431282001,
739427227001,
738431218001,
818589059001,
738412506001,
1456756742001,
802413688001,
738305083001,
738431220001,
1547518183001,
1547416198001,
818706622001,
822945520001,
818776313001,
738305079001,
738436465001,
1481227014001,
818756764001,
738313139001,
738433026001,
738412503001,
738431217001,
847335868001,
738314949001,
738433023001,
746406920001,
738433058001,
756527912001,
818575676001,
738313156001,
738431238001,
738433024001,
822945890001,
742130421001,
738305100001,
1443616034001,
738431216001,
754369878001,
738433022001";


        public static List<string> OverlappingIds(List<string> deleteIds)
        {
            List<string> ret = new List<string>();
            List<string> activeIDs = UsedIDs.GetActiveIDs();

            for (int i = 0; i < activeIDs.Count(); ++i)
            {
                if (deleteIds.Contains(activeIDs[i]))
                {
                    ret.Add(activeIDs[i]);
                }
            }

            return ret;
        }


        static void Main(string[] args)
        {
            /*PrintActiveVideo();
            PrintVideosByPlayTotal(0);
            PrintVideosByPlayTotal(10);
            PrintVideosByPlayTotal(30);*/
            
            PopulateBCVideoTable();
            DownloadVideoFiles();

            return;
        }

        public static void AddVideo(BrightcoveVideo vid)
        {
            
        }
        public static void DownloadVideoFiles()
        {
            string destFolder = @"N:\Development\PRI_BC_Videos\";
            string dest2Folder = @"N:\Development\PRI_myPRIME_BC_Videos\";
            List<Videos> videos = Videos.GetAllVideos();
            for (int i = 0; i < videos.Count; ++i)
            {
                
                WebClient myWebClient = new WebClient();
                if (videos[i].flvurl.Contains("rtmp:"))
                {
                    FlvStuffer flvStuffer = null;
                }
                string []array = videos[i].flvurl.Split('/');
                if(array.Count() > 0)
                {
                    string filename = array[array.Count()-1];
                    string fullpath = string.Empty;
                    if (videos[i].accountid == "PRI")
                        fullpath = destFolder + filename;                       
                    else
                        fullpath = dest2Folder + filename;
                    if (!File.Exists(fullpath))
                    {
                        Console.WriteLine(i + 1 + " of " + videos.Count + " Downloading file to " + fullpath);
                        myWebClient.DownloadFile(videos[i].flvurl,fullpath);
                    }
                    else
                    {
                        Console.WriteLine(i + 1 + " of " + videos.Count + " file exists " + destFolder + filename);
                    }
                }
            }
        }
        public static string BC_PRI_READ_TOKEN = "sr-XAL22dZ2-j7cS9fvdCdkSoIWcuvgaNJYyxw7HkvYvNIGZhoG1dA..";
        public static string BC_MYPRIME_READ_TOKEN = "NiU1brWPYqqJi3wuuRQjKrWULoOYzfjweBX8q0FUNsCEYM_Jor5HHw..";


        public static void PopulateBCVideoTable()
        {
            Videos.DeleteAll();
            PopulateBCVideoTable(BC_MYPRIME_READ_TOKEN, "MYPRIME");
            PopulateBCVideoTable(BC_PRI_READ_TOKEN, "PRI");
            
        }
        

        public static void PopulateBCVideoTable(string tokenStr,string accountType)
        {
            BrightcoveApi api = BrightcoveApiFactory.CreateApi(tokenStr,string.Empty,"http");
            
            

            BrightcoveItemCollection<BrightcoveVideo> videos = api.FindAllVideos(50, 0);
            bool cont = true;
            int ii = 1;
            while (cont)
            {
                BrightcoveItemCollection<BrightcoveVideo> vid = api.FindAllVideos(50, ii);
                if (vid.Count > 0)
                {
                    videos.AddRange(vid);
                    
                    ii++;
                }
                else
                    cont = false;
            }

            int count = 0;
            for (int i = 0; i < videos.Count; ++i)
            {
                try
                {
                    count++;
                    Console.WriteLine(videos[i].FlvUrl);
                    Videos vid = new Videos();
                    
                    vid.id = videos[i].Id.ToString();
                    vid.accountid = accountType;//videos[i].AccountId.ToString();
                    vid.creationdate = videos[i].CreationDate == DateTime.MinValue ? DateTime.Now : videos[i].CreationDate;
                    vid.enddate = videos[i].EndDate == DateTime.MinValue ? DateTime.Now : videos[i].EndDate;
                    vid.flvurl = videos[i].FlvUrl;
                    vid.itemstate = videos[i].ItemState.ToString();
                    vid.lastmodified = videos[i].LastModifiedDate == DateTime.MinValue ? DateTime.Now : videos[i].LastModifiedDate;
                    vid.length = videos[i].Length.ToString();
                    vid.linktext = videos[i].LinkText;
                    vid.linkurl = videos[i].LinkUrl;
                    vid.longdescription = videos[i].LongDescription;
                    vid.name = videos[i].Name;
                    vid.playstotal = videos[i].PlaysTotal;
                    vid.playstrailingweek = videos[i].PlaysTrailingWeek;
                    vid.publishdate = videos[i].PublishedDate == DateTime.MinValue ? DateTime.Now : videos[i].PublishedDate;
                    vid.referenceid = videos[i].ReferenceId;
                    vid.shortdescription = videos[i].ShortDescription;
                    vid.startdate = videos[i].StartDate == DateTime.MinValue ? DateTime.Now : videos[i].StartDate;
                    vid.thumbnailurl = videos[i].ThumbnailUrl;
                    vid.videostillurl = videos[i].VideoStillUrl;

                    if(videos[i].FlvUrl.Contains("rtmp:")){
                        int  debug = 0;
                    }
                    Videos.Insert(vid);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }

        public static void PrintVideosByPlayTotal(int playTotalCap)
        {
            
            // Instantiate an API object by using the provided factory
            BrightcoveApi api = BrightcoveApiFactory.CreateApi("NiU1brWPYqqJi3wuuRQjKrWULoOYzfjweBX8q0FUNsCEYM_Jor5HHw..");
            List<string> activeIDs = UsedIDs.GetActiveIDs();

            // NOTE: API calls are subject to the whims of internet connectivity, and may throw an exception for any number of reasons. 
            // NOTE: To ensure that your app is as robust as possible, make sure to try/catch all API calls (not shown here).

            //string[] array = IDs.Split(',');

            /*List<string> allIDs = new List<string>();
            for (int i = 0; i < array.Count(); ++i)
            {
                array[i] = array[i].Replace("\r\n", "");
                allIDs.Add(array[i]);
            }*/

            // Perform the "find_all_videos" API call
            BrightcoveItemCollection<BrightcoveVideo> videos = api.FindAllVideos(50, 0);
            bool cont = true;
            int ii = 1;
            while (cont)
            {
                BrightcoveItemCollection<BrightcoveVideo> vid = api.FindAllVideos(50, ii);
                if (vid.Count > 0)
                {
                    videos.AddRange(vid);
                    ii++;
                }
                else
                    cont = false;
            }

            

            //foreach (BrightcoveVideo video in videos)
            //{
                // do something with each video
            //}
            string output = string.Empty;
            if (playTotalCap == 0)
                output = "<h1>Complete List of Video Candidates for Removal from Brightcove Account</h1>";
            else
            {
                output = "<h1> List of Video Candidates for Removal from Brightcove Account with less than "+playTotalCap+" Plays</h1>";
            }
            output += "<table><tr><td><b>ID</b></td><td><b>Name</b></td><td><b>TotalPlays</b></td><td><b>Thumb</b></td><td><b>Pub Date</b></td><td><b>Rendition Dims</b></td></tr>";
            List<string> IdsToDelete = new List<string>();
            int count = 0;
            for (int i = 0; i < videos.Count; ++i)
            {
                try
                {
                    if (activeIDs.Contains(videos[i].Id.ToString()))
                        continue;
                    string renditionDimStr = string.Empty;
                    BrightcoveVideo video = videos[i];//api.FindVideoById(Convert.ToInt64(array[i]));
                    List<int> widths = new List<int>();
                    List<int> heights = new List<int>();
                    foreach (BrightcoveRendition rendition in video.Renditions)
                    {
                        if (widths.Contains(rendition.FrameWidth) && heights.Contains(rendition.FrameHeight))
                            continue;
                        widths.Add(rendition.FrameWidth);
                        heights.Add(rendition.FrameHeight);
                        renditionDimStr += rendition.FrameWidth + "x" + rendition.FrameHeight + ",";
                    }
                    if(renditionDimStr != string.Empty)
                        renditionDimStr = renditionDimStr.Remove(renditionDimStr.Length - 1);
                    
                    if (video == null)
                        continue;
                    string name = video.Name;
                    int playsTotal = video.PlaysTotal;
                    string thumbURL = video.ThumbnailUrl;
                    DateTime publishDate = video.PublishedDate;
                    //string videoURL = video.FlvUrl;
                    if (playTotalCap == 0 || playsTotal < playTotalCap )
                    {
                        IdsToDelete.Add(video.Id.ToString());
                        count++;
                        output += "<tr><td><b>"+video.Id+"</b></td><td><b>" + count +") " + name + "</b></td><td><b>" + playsTotal + "</b></td><td><b><img src=\"" + thumbURL + "\" /></b></td><td><b>" + publishDate + "</b></td><td>"+renditionDimStr+"</td></tr>";
                    }

                }
                catch (Exception e)
                {
                    //Console.WriteLine("Entry = "+ array[i]+" Error:" + e.Message);
                    Console.WriteLine("Entry = "+ videos[i].Id+" Error:" + e.Message);
                }
                



            }


            List<string> overlapIDs = OverlappingIds(IdsToDelete);

            if (overlapIDs.Count > 0)
            {
                Console.WriteLine("There were ID conficts with the do not delete list!");
            }

            output += "</table>";
            // create a writer and open the file
            TextWriter tw;
            if(playTotalCap > 0)
                tw = new StreamWriter("removal_candidates_with_less_than_"+playTotalCap+"_plays.html");
            else
                tw = new StreamWriter("complete_List_removal_candidates.html");

            // write a line of text to the file
            tw.WriteLine(output);

            // close the stream
            tw.Close();
        }
    





        static void PrintActiveVideo()
        {
            
            // Instantiate an API object by using the provided factory
            BrightcoveApi api = BrightcoveApiFactory.CreateApi("NiU1brWPYqqJi3wuuRQjKrWULoOYzfjweBX8q0FUNsCEYM_Jor5HHw..");
            List<string> activeIDs = UsedIDs.GetActiveIDs();

            // NOTE: API calls are subject to the whims of internet connectivity, and may throw an exception for any number of reasons. 
            // NOTE: To ensure that your app is as robust as possible, make sure to try/catch all API calls (not shown here).

            //string[] array = IDs.Split(',');

            /*List<string> allIDs = new List<string>();
            for (int i = 0; i < array.Count(); ++i)
            {
                array[i] = array[i].Replace("\r\n", "");
                allIDs.Add(array[i]);
            }*/

            // Perform the "find_all_videos" API call
            /*BrightcoveItemCollection<BrightcoveVideo> videos = api.FindAllVideos(50, 0);
            bool cont = true;
            int ii = 1;
            while (cont)
            {
                BrightcoveItemCollection<BrightcoveVideo> vid = api.FindAllVideos(50, ii);
                if (vid.Count > 0)
                {
                    videos.AddRange(vid);
                    ii++;
                }
                else
                    cont = false;
            }*/

            

            //foreach (BrightcoveVideo video in videos)
            //{
                // do something with each video
            //}
            string output = string.Empty;
            output = "<h1>Complete List of Live Course Videos</h1>";
            output += "<table><tr><td><b>ID</b></td><td><b>Name</b></td><td><b>TotalPlays</b></td><td><b>Thumb</b></td><td><b>Pub Date</b></td><td><b>Rendition Dims</b></td></tr>";
            List<string> IdsToDelete = new List<string>();
            int count = 0;
            for (int i = 0; i < activeIDs.Count; ++i)
            {
                try
                {
                    string renditionDimStr = string.Empty;
                    BrightcoveVideo video = api.FindVideoById(Convert.ToInt64(activeIDs[i]));
                    List<int> widths = new List<int>();
                    List<int> heights = new List<int>();
                    foreach (BrightcoveRendition rendition in video.Renditions)
                    {
                        if (widths.Contains(rendition.FrameWidth) && heights.Contains(rendition.FrameHeight))
                            continue;
                        widths.Add(rendition.FrameWidth);
                        heights.Add(rendition.FrameHeight);
                        renditionDimStr += rendition.FrameWidth + "x" + rendition.FrameHeight + ",";
                    }
                    if(renditionDimStr != string.Empty)
                        renditionDimStr = renditionDimStr.Remove(renditionDimStr.Length - 1);
                    
                    if (video == null)
                        continue;
                    string name = video.Name;
                    int playsTotal = video.PlaysTotal;
                    string thumbURL = video.ThumbnailUrl;
                    DateTime publishDate = video.PublishedDate;
                    //string videoURL = video.FlvUrl;
                    //if (playsTotal < 30 )
                    //{
                        IdsToDelete.Add(video.Id.ToString());
                        count++;
                        output += "<tr><td><b>"+video.Id+"</b></td><td><b>" + count +") " + name + "</b></td><td><b>" + playsTotal + "</b></td><td><b><img src=\"" + thumbURL + "\" /></b></td><td><b>" + publishDate + "</b></td><td>"+renditionDimStr+"</td></tr>";
                    //}

                }
                catch (Exception e)
                {
                    //Console.WriteLine("Entry = "+ array[i]+" Error:" + e.Message);
                    Console.WriteLine("Entry = "+ activeIDs[i]+" Error:" + e.Message);
                }
                



            }


            

            output += "</table>";
            // create a writer and open the file
            TextWriter tw = new StreamWriter("do_not_remove_videos.html");

            // write a line of text to the file
            tw.WriteLine(output);

            // close the stream
            tw.Close();
        }

        /*

        /////////////////////////////////////////////////////////////
        // constants and enumerations

        // store the audio and video in an Flv file
        private static readonly String FlvFilepath = "c:\\FileDump.flv";

        /////////////////////////////////////////////////////////////
        // the rtmp connection parameters

        private static readonly String RtmpServer = "flash.princeton.edu";
        private static readonly UInt32 RtmpPort = RtmpClient.DefaultRtmpPort;
        private static readonly String RtmpApp = "puvod";
        private static readonly String RtmpTcUrl = "rtmp://flash.princeton.edu/puvod/mp4:FILES/engvideo/public_html/andlinger/20081218_sreenivasan_new.mp4";
        private static readonly String RtmpStreamName = "mp4:FILES/engvideo/public_html/andlinger/20081218_sreenivasan_new.mp4";

        /////////////////////////////////////////////////////////////////
		// main application function

		static void Main(string[] args)
		{

			// display message - app has started
			Console.WriteLine("RtmpDownloader Started.");

			// A - start by opening the target file
			FlvStuffer flvStuffer = null;
			try
			{

				// A - start by opening the target file
				Console.WriteLine("Opening flv target file...");
				flvStuffer = new FlvStuffer(FlvFile.CreateFileW(FlvFilepath));

			}
			catch (Exception x)
			{

				// display message and update flag
				Console.WriteLine(x.Message);

				// Clean references
				if (flvStuffer != null)
				{
					flvStuffer.Dispose();
					flvStuffer = null;
				}

			}

			// if that worked...
			if (flvStuffer!=null)
			{

				// B - create an RTMP client object
				Console.WriteLine("Creating Rtmp client.");
				using (RtmpClient rtmpClient = new RtmpClient(null))
				{

					// This example program doesn't use events, so they can be disabled
					rtmpClient.EventsEnabled = false;

					// C - Declare RTMP connection and stream objects
					RtmpConnection rtmpConn = null;
					RtmpStream rtmpStream = null;
					try
					{

						// D - Connect to the RTMP server
						Console.WriteLine("Creating Rtmp connection to {0}:{1}.", RtmpServer, RtmpPort);
						rtmpConn = rtmpClient.CreateConnection(
							RtmpServer, 
							RtmpPort, 
							RtmpConnection.eProtocol.RTMP,
							RtmpConnection.eBehaviourFlags.AutoChopUpAggregateMessages |
							RtmpConnection.eBehaviourFlags.AutoRespondToSetPeerBW |
							RtmpConnection.eBehaviourFlags.AutoPingPong |
							RtmpConnection.eBehaviourFlags.AutoDataAckReceivedData |
							RtmpConnection.eBehaviourFlags.AutoRespondToBandwidthCheck |
							RtmpConnection.eBehaviourFlags.AutoAdjustAggregatedMediaMsgTarget
						);

						// E - Timeout waiting for responses
						rtmpConn.ResponseTimeout = 10 * 1000;

						// F - invoke a connection to the streaming application (un-modified connection message)
						Console.WriteLine("Invoking application.");
						rtmpConn.ConnectToApplication(
							RtmpApp,		// app name
							RtmpClient.DummyFlashVersion,
							null,			// swf url
							RtmpTcUrl,		// tc url
							false,
							RtmpConnection.eCaps.DefaultCaps,
							RtmpConnection.eAudioCodec.SUPPORT_SND_ALL,
							RtmpConnection.eVideoCodec.SUPPORT_VID_ALL,
							RtmpConnection.eVideoFunction.SUPPORT_VID_CLIENT_SEEK,
							null
						);

						// G - open a stream
						Console.WriteLine("Creating stream.");
						rtmpStream = rtmpConn.CreateStream();
						Console.WriteLine("Stream id = {0}.", rtmpStream.StreamId);
						rtmpStream.SetBufferSize(100 * 1000);

						// H - Use an anonymous callback function to store the messages in the FLV file
						rtmpStream.RegisterForPreProcessing(
							(RtmpMessage msg, object oTag) =>
							{
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine(msg.ToString());
								Console.ForegroundColor = ConsoleColor.DarkGray;
								flvStuffer.AddRtmpMessage(msg);
							}, 
							null,
							RtmpStream.eCallbackFilterFlags.All
						);

						// I - "play" the stream
						Console.WriteLine("Playing stream.");
						rtmpStream.Play(RtmpStreamName, 0, RtmpStream.SpecialDurationValue_PlayAll);

						// display cancel instruction for the user
						Console.WriteLine("(When download starts, press \"C\" to cancel.)");

						// J - wait for the stream to complete
						while (rtmpStream.State == RtmpStream.eState.Streaming)
						{

							// sleep to prevent processor spinning
							Thread.Sleep(1000);

							// check for cancel
							if (Console.KeyAvailable)
							{

								// get key details
								ConsoleKeyInfo key = Console.ReadKey(true);
								if (key.Key == ConsoleKey.C)
								{

									// display error and break out of loop
									Console.WriteLine("- - -  Operation cancelled by user.  - - -");
									break;

								}

							}

						} // while-loop

					}
					catch (Exception x)
					{

						// dump exception
						Console.WriteLine();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine(String.Format("!!! {0}", x.Message));
						Console.ForegroundColor = ConsoleColor.Gray;
						Console.WriteLine();

					}
					finally
					{

						// K - close down stream
						if ((rtmpStream != null) && (rtmpStream.IsValid() == null))
							rtmpStream.Close();
						rtmpStream = null;

						// K - close the connection
						if ((rtmpConn != null) && (rtmpConn.IsValid() == null))
							rtmpConn.Close();
						rtmpConn = null;

						// L - close FlvFile
						Console.WriteLine("Closing target file...");
						if (flvStuffer != null)
						{
							flvStuffer.Dispose();
							flvStuffer = null;
						}

					}

				} // using RtmpClient

			}

			// app has finished
			Console.WriteLine("\nRtmpDownloader Finished.");
			Console.WriteLine("Click any key to close...");
			while (!Console.KeyAvailable) { }

		}*/

	}
    

    

}
