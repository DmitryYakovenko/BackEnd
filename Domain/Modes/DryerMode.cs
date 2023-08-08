using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Modes
{
    public class DryerMode
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public int BurnerTemp { get; set; }
        public double PupeTemp1 { get; set; }
        public double PupeTemp2 { get; set; }
        public double GazPressure { get; set; }
        public double Humidity { get; set; }
        public int VentilationGate { get; set; }
        public int StreetGate { get; set; }
        public int CameraGate { get; set; }
        public int Shaking { get; set; }
    }
}
