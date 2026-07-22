using System.Runtime.Versioning;
using DBAHawkSharedGUI;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Custom ToolStrip/Menu Renderer for Dark Mode
    /// </summary>
    [SupportedOSPlatform("windows")]
    public class LightModeMenuRenderer : BaseMenuRenderer
    {
        public LightModeMenuRenderer() : base(new LightModeColors())
        {
        }

        public override Color MenuBackColor { get; set; } = HawkColors.Gray0;

        public override Color MenuForeColor { get; set; } = HawkColors.HawkBlueDark;
        public override Color ArrowColor { get; set; } = HawkColors.HawkBlue;
        public override Color SeparatorColor { get; set; } = HawkColors.Gray8;

        public override Color SelectionColor { get; set; } = HawkColors.HawkBlueDark;

        public override Color SelectionForeColor { get; set; } = HawkColors.White;
    }
}