using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace IOTProject.Controllers.APIs
{
    public class InformDefectController : ApiController
    {
        public void Get(string beltId, string defectId)
        {
 

            using (IOTMOdel context = new IOTMOdel())
            {

               

                string query_1 = @"INSERT INTO [dbo].[Identifies]([DefectID],[BeltID],[IdentifiedTime])VALUES('"+ defectId + "','"+ beltId + "2' ,'"+ DateTime.Now+ "')";
            
                Debug.WriteLine(query_1);

                try
                {
                    context.Database.ExecuteSqlCommand(query_1);
                    var lineInfo = context.IPs.Where(x => x.RaspBerryID == 2).FirstOrDefault();
                    TakeAction(lineInfo.IPAddress, defectId);
                }

                catch (Exception ex)
                {
                    Debug.WriteLine("Error " + ex);
                }
            }
        }

        public void TakeAction(string ip, string defectId)
        {
            string url = "http://" + ip + "/led.php?on=" + defectId;
            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(string.Format(url));
            webReq.Method = "GET";
            HttpWebResponse webResponse = (HttpWebResponse)webReq.GetResponse();
            Debug.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$" + webResponse);
        }



        //Realtime update the status
         [System.Web.Http.Route("api/InformRealtimedefect")]
        public void Get( bool def1, bool def2, bool def3, bool def4)
        {


            using (IOTMOdel context = new IOTMOdel())
            {



                string query_1 = @"INSERT INTO [dbo].[Switches]([Defect1],[Defect2],[Defect3],[Defect4],[Time])VALUES('" + def1 + "','" + def2 + "','" + def3 + "','" + def4 + "','" + DateTime.Now + "')";

                Debug.WriteLine(query_1);

                try
                {
                    context.Database.ExecuteSqlCommand(query_1);
                  
                   
                }

                catch (Exception ex)
                {
                    Debug.WriteLine("Error " + ex);
                }
            }
        }



    }
}
