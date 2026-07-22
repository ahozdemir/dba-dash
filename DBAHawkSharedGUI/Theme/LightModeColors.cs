using DBAHawkSharedGUI;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Professional Color table for menu/tool strip items in light mode
    /// </summary>
    public class LightModeColors : ProfessionalColorTable
    {
        public override Color CheckBackground => HawkColors.GrayLight;

        public override Color CheckPressedBackground => HawkColors.Gray10;

        public override Color CheckSelectedBackground => HawkColors.HawkGray;

        public override Color MenuItemSelected => HawkColors.Gray10;

        public override Color ToolStripDropDownBackground => HawkColors.HawkGray;

        public override Color SeparatorDark => HawkColors.Gray8;

        public override Color ImageMarginGradientBegin => Color.White;

        public override Color ImageMarginGradientEnd => HawkColors.Gray1;

        public override Color ImageMarginGradientMiddle => HawkColors.Gray0;
    }
}