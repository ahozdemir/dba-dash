using System.Runtime.Versioning;
using DBAHawkSharedGUI;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Custom ToolStrip/Menu Renderer for Dark Mode
    /// </summary>
    [SupportedOSPlatform("windows")]
    public class LightModeAltMenuRenderer : BaseMenuRenderer
    {
        public LightModeAltMenuRenderer() : base(new LightModeAltColors())
        {
        }

        public override Color MenuBackColor { get; set; } = HawkColors.BluePale;

        public override Color MenuForeColor { get; set; } = HawkColors.HawkBlueDark;
        public override Color ArrowColor { get; set; } = HawkColors.Gray8;
        public override Color SeparatorColor { get; set; } = HawkColors.Gray8;

        public override Color SelectionColor { get; set; } = HawkColors.HawkBlue;

        public override Color SelectionForeColor { get; set; } = HawkColors.White;
    }
}