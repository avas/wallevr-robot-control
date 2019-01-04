using System.Threading.Tasks;

namespace WalleVR.RobotControl.Core
{
    public interface ICameraArm
    {
        double MinHeight { get; }
        double MaxHeight { get; }

        Task SetBasePosition(double pitch, double roll);
        Task SetHeadPosition(double pitch, double roll);
        Task SetHeight(double height);
    }
}