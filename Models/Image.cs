namespace RoadDefectService.Models
{
    public class Image
    {
        public int DefectsX { get; set; }
        public int DefectsY { get; set; }
        public Defects Defects { get; set; }
        public byte[] Data { get; set; }
    }
}
