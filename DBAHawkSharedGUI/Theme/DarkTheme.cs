using DBAHawkSharedGUI;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Theme colors for Dark Mode
    /// </summary>
   public  class DarkTheme : BaseTheme
    {
        public override ThemeType ThemeIdentifier => ThemeType.Dark;

        public DarkTheme()
        {
            ForegroundColor = Color.White;
            BackgroundColor = HawkColors.HawkGray;
            GridGridlineColor = Color.White;
            GridCellForeColor = Color.White;
            GridCellBackColor = HawkColors.HawkGray;
            GridBackgroundColor = HawkColors.HawkGray;
            LinkColor = HawkColors.BluePale;
            NotApplicableBackColor = HawkColors.Gray9;
            NotApplicableForeColor = HawkColors.White;
            DisabledBackColor = HawkColors.Gray7;
            DisabledForeColor = HawkColors.White;
            SearchBackColor = HawkColors.Gray9;
            TimeZoneBackColor = HawkColors.Gray9;
            TimeZoneForeColor = HawkColors.White;
            TitleBackColor = HawkColors.Gray9;
            TitleForeColor = HawkColors.White;

            TimelineTitleForeColor = HawkColors.White;
            TimelineTitleBackColor = HawkColors.HawkGray;
            TimelineBodyBackColor = HawkColors.Gray9;
            TimelineBodyForeColor = HawkColors.White;
            TimelineLabelColor = HawkColors.White;
            TimelineChartBackColor = HawkColors.Gray8;
            TimelineGridColor = HawkColors.White;
            TimelineToolTipBackColor = HawkColors.HawkGray;
            TimelineToolTipForeColor = HawkColors.White;

            PanelBackColor = HawkColors.HawkGray;
            PanelForeColor = HawkColors.White;
            ButtonBackColor = HawkColors.HawkBlueDark;
            ButtonForeColor = HawkColors.White;
            ButtonBorderColor = HawkColors.HawkBlue;
            TreeViewBackColor = HawkColors.Gray9;
            TreeViewForeColor = HawkColors.White;
            CodeEditorBackColor = HawkColors.Gray9;
            CodeEditorForeColor = HawkColors.White;
            TabBackColor = HawkColors.Gray9;
            TabBorderColor = HawkColors.BluePale;
            InputBackColor = HawkColors.Gray7;
            InputForeColor = HawkColors.White;
        }
    }
}