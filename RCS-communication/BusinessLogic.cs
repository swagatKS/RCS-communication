using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCS_communication
{
    public static class BusinessLogic
    {
        public static string SystemId = "VITSSK";
        public static string GenerateId()
        {
            string formattedDate = DateTime.Now.ToString("yyyyMMddHHmmss");
            string dateTimeMilli = formattedDate + DateTime.Now.Millisecond.ToString();
            string id = "T" + dateTimeMilli;
            return id;
        }


    }
}
