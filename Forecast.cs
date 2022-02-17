using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class Forecast
    {
        public Forecast()
        {
        }

        public int NumOfDays { get; set; }
        public string ProjectName { get; set; }
        public DateTime Date { get;set; }

        public override string ToString()
        {
            return $"{Date.Day}/{Date.Month}/{Date.Year}, {ProjectName}, {NumOfDays}";
        }

    }
}
