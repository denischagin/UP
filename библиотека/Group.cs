using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace библиотека
{
    public class Group
    {
        public int Id { get; set; }
        public Special Special { get; set; }
        public int ClassRoom { get; set; }
        public int SubGroup  { get; set; }


        public int StartYear { get; set; }

        public static void CreateGroups()
        {

        }
        public string GetCode()
        {
            int kourse = DateTime.Now.Year - StartYear;
            if (DateTime.Now.Month >= 9) kourse++;

            return $"{kourse}-{SubGroup}{Special.Code}";
        }
    }
}
