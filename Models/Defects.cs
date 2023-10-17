using System.ComponentModel.DataAnnotations;
namespace RoadDefectService.Models
{
    public class Defects
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Image Image { get; set; }
        public bool AlligatorCracking { get; set; }
        public bool EdgeCracking { get; set; }
        public bool LongitudinalCracking { get; set; }
        public bool Patching { get; set; }
        public bool Pothole { get; set; }
        public bool Rutting { get; set; }
        public bool TransverseCracking { get; set; }
    }
}
