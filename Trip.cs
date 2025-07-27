using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public struct ThePoint { public double x; public double y; }
  
    internal class Trip
    {
        public int TripNumber { get; set; }
        ThePoint IniPoint { get; set; }
        ThePoint EndPoint { get; set; }
        public int Price { get; set; }
        public DateTime TripTime { get; set; }
        public string TripType { get; set; }
        public double TripRate { get; set; }
        public double CalculatePrice(string StartPoint,string EndPoing)
        {
            return Math.Sqrt(Math.Pow((EndPoint.x - IniPoint.x), 2) + Math.Pow((EndPoint.y - IniPoint.y), 2));
        }



    }
}
