using RoadDefectService.Models;

namespace RoadDefectService.Services
{
    public interface IRoadService
    {
        Defects PostPhoto(Image image);
        ICollection<Defects> GetDefects();
        bool SetDefect(Defects defect);
        Defects RemoveDefect(int x, int y);
    }
}
