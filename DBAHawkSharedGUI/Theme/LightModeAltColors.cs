using DBAHawkSharedGUI;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Professional Color table for menu/tool strip items in dark mode
    /// </summary>
    public class LightModeAltColors : ProfessionalColorTable
    {
        public override Color CheckBackground => HawkColors.BlueLight;

        public override Color CheckPressedBackground => HawkColors.White;

        public override Color CheckSelectedBackground => HawkColors.HawkBlue;

        public override Color MenuItemSelected => HawkColors.Gray10;

        public override Color ToolStripDropDownBackground => HawkColors.HawkGray;

        public override Color SeparatorDark => HawkColors.Gray8;

        public override Color ImageMarginGradientBegin => HawkColors.BluePale;

        public override Color ImageMarginGradientEnd => HawkColors.BluePale;

        public override Color ImageMarginGradientMiddle => HawkColors.BluePale;
    }
}