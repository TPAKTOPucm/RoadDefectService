using RoadDefectService.Models;

namespace RoadDefectService.Services
{
    public interface IRoadService
    {
        Defects PostPhoto(byte[] image);
        ICollection<Defects> GetDefects();
        bool SetDefect(Defects defect);
        bool RemoveDefect(int x, int y);
    }
}
