using DBAHawkSharedGUI;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Theme colors for White theme
    /// </summary>
    public class WhiteTheme : BaseTheme
    {
        public override ThemeType ThemeIdentifier => ThemeType.White;

        public WhiteTheme()
        {
            BackgroundColor = Color.White;
            GridCellBackColor = Color.White;
            GridBackgroundColor = Color.White;
            TimelineBodyBackColor = HawkColors.White;
            TimelineChartBackColor = HawkColors.White;
            TreeViewBackColor = HawkColors.White;
            CodeEditorBackColor = HawkColors.White;
            TabBackColor = HawkColors.White;
            SearchBackColor = HawkColors.White;
        }
    }
}