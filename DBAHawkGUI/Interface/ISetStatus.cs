using System.Drawing;

namespace DBAHawkGUI.Interface
{
    public interface ISetStatus : IRefreshData
    {
        public void SetStatus(string message, string tooltip, Color color);
    }
}