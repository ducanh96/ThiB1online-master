using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebThiB1Online.Areas.admin.Models
{
    public class CauHoi
    {
        public int ID { get; set; }
        public string TieuDe { get; set; }
        public string DapAnA { get; set; }
        public string DapAnB { get; set; }
        public string DapAnC { get; set; }
        public string DapAnD { get; set; }
        public string DapAn { get; set; }
        public static List<CauHoi> dsCauHoi
        {
            get
            {
                List<CauHoi> lstTam = new List<CauHoi>();
                using (B1OnlineEntities context = new B1OnlineEntities())
                {
                    foreach (var item in context.CauHois)
                    {
                        lstTam.Add(
                        new CauHoi
                        {
                            ID = item.ID,
                            DapAnA = item.PhuongAnA,
                            DapAnB = item.PhuongAnB,
                            DapAnC = item.PhuongAnC,
                            DapAnD = item.PhuongAnD,
                            DapAn = item.DapAn,
                            TieuDe = item.TieuDe
                        });
                    }
                    return lstTam;
                };
            }
        }
        public static  List<CauHoi> LayDSCauHoi(int MaTopic)
        {

            return dsCauHoi;
        }
        public static bool deleteCauHoi(int ID)
        {
           return false;
        }
    }
  

}