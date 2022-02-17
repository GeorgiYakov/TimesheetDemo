using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class DailyWork
    {
        public DailyWork()
        {

        }

        public DateTime Day { get; set; }    
        public string Project { get; set; } 
        public TimeSpan From { get; set; }  
        public TimeSpan To { get; set; }
        public int Pause { get; set; }  
        public string Description { get; set; }
    }
}
