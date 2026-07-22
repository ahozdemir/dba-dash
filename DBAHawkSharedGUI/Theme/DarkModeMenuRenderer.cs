using System.Runtime.Versioning;
using DBAHawkSharedGUI;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Custom ToolStrip/Menu Renderer for Dark Mode
    /// </summary>
    [SupportedOSPlatform("windows")]
    public class DarkModeMenuRenderer : BaseMenuRenderer
    {
        public DarkModeMenuRenderer() : base(new DarkModeColors())
        {
        }

        public override Color MenuBackColor { get; set; } = HawkColors.Gray7;

        public override Color MenuForeColor { get; set; } = HawkColors.White;
        public override Color ArrowColor { get; set; } = HawkColors.White;
        public override Color SeparatorColor { get; set; } = HawkColors.Gray8;

        public override Color SelectionColor { get; set; } = HawkColors.HawkBlue;
    }
}