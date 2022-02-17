using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public static class WorkDaysList
    {
        public static List<WorkDay> GetWorkDays()
        {
            var workdaylist = new List<WorkDay>
            {
                new WorkDay{ Key = "January", Value = 20},
                new WorkDay{ Key = "February", Value = 20},
                new WorkDay{ Key = "March", Value = 23},
                new WorkDay{ Key = "April", Value = 19},
                new WorkDay{ Key = "May", Value = 21},
                new WorkDay{ Key = "June", Value = 20},
                new WorkDay{ Key = "July", Value = 21},
                new WorkDay{ Key = "August", Value = 23},
                new WorkDay{ Key = "September", Value = 22},
                new WorkDay{ Key = "October", Value = 20},
                new WorkDay{ Key = "November", Value = 21},
                new WorkDay{ Key = "December", Value = 21},
            };

            return workdaylist;
        }
    }
}
