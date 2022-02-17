using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public static class DailyWorkList
    {
        public static List<DailyWork> GetDailyWorkList()
        {
            List<DailyWork> list = new List<DailyWork> {
                new DailyWork{ Day = new DateTime(2022,2,1), Description = "Programming", From = new TimeSpan(8,0,0), To = new TimeSpan(16,30,0), Pause = 30, Project = "Amazon"},
                new DailyWork{ Day = new DateTime(2022,2,2), Description = "BugFix", From = new TimeSpan(8,0,0), To = new TimeSpan(16,30,0), Pause = 40, Project = "Facebook"},
                new DailyWork{ Day = new DateTime(2022,2,3), Description = "Programming", From = new TimeSpan(8,0,0), To = new TimeSpan(16,30,0), Pause = 20, Project = "Google"},
                new DailyWork{ Day = new DateTime(2022,2,4), Description = "Startup", From = new TimeSpan(8,0,0), To = new TimeSpan(16,30,0), Pause = 70, Project = "Amazon"},
                new DailyWork{ Day = new DateTime(2022,2,5), Description = "Update", From = new TimeSpan(8,0,0), To = new TimeSpan(16,30,0), Pause = 10, Project = "Microsoft"},
                new DailyWork{ Day = new DateTime(2022,2,6), Description = "Maintenance", From = new TimeSpan(8,0,0), To = new TimeSpan(16,30,0), Pause = 30, Project = "Amazon"},
            };

            return list;
        }
    }
}
