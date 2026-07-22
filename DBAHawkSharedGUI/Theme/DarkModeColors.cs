using DBAHawkSharedGUI;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Professional Color table for menu/tool strip items in dark mode
    /// </summary>
    public class DarkModeColors : ProfessionalColorTable
    {
        public override Color CheckBackground => HawkColors.HawkGray;

        public override Color CheckPressedBackground => HawkColors.Gray10;

        public override Color CheckSelectedBackground => HawkColors.HawkGray;

        public override Color MenuItemSelected => HawkColors.Gray10;

        public override Color ToolStripDropDownBackground => HawkColors.HawkGray;

        public override Color SeparatorDark => HawkColors.Gray8;

        public override Color ImageMarginGradientBegin => HawkColors.Gray5;

        public override Color ImageMarginGradientEnd => HawkColors.Gray9;

        public override Color ImageMarginGradientMiddle => HawkColors.Gray7;
    }
}