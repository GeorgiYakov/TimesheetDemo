using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public class FederalStates
    {
        public List<FederalState> FederalStatesList { get; set; }
        public FederalStates()
        {
            FederalStatesList = GetFederalStates().OrderBy(f => f.Value).ToList();
        }

        string states ="Baden-Württemberg	" +
            "Bayern	" +
            "Berlin	" +
            "Brandenburg	" +
            "Bremen	Hamburg	" +
            "Hessen	" +
            "Mecklenburg-Vorpommern	" +
            "Nieder-sachsen	" +
            "Nordrhein-Westfalen	" +
            "Rheinland-Pfalz	" +
            "Saarland	" +
            "Sachsen	" +
            "Sachsen-Anhalt	" +
            "Schleswig-Holstein	" +
            "Thüringen";
        private List<FederalState> GetFederalStates()
        {
            return new List<FederalState>()
            {
                new FederalState() {Key = 1, Value="first"},
                new FederalState() {Key = 2, Value="second"},
                new FederalState() {Key = 3, Value="third"},
            };
        }
    }

    public class FederalState
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
