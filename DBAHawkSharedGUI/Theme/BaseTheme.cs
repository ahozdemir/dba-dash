using DBAHawkSharedGUI;
using Color = System.Drawing.Color;

namespace DBAHawkGUI.Theme
{
    /// <summary>
    /// Base theme used to style the application.  Provides defaults that can be overridden.
    /// </summary>
    public class BaseTheme
    {
        public virtual ThemeType ThemeIdentifier => ThemeType.Default;

        public Color ForegroundColor { get; set; } = HawkColors.HawkBlueDark;
        public Color BackgroundColor { get; set; } = HawkColors.GrayLight;

        public Color GridGridlineColor { get; set; } = SystemColors.Control;

        public Color GridCellBackColor { get; set; } = HawkColors.GrayLight;

        public Color GridCellForeColor { get; set; } = HawkColors.HawkBlueDark;

        public Color GridBackgroundColor { get; set; } = HawkColors.GrayLight;

        public Color LinkColor { get; set; } = HawkColors.LinkColor;

        public Color WarningBackColor { get; set; } = HawkColors.Warning;
        public Color WarningForeColor { get; set; } = HawkColors.Warning.ContrastColor();

        public Color WarningLowBackColor { get; set; } = HawkColors.YellowPale;

        public Color WarningLowForeColor { get; set; } = HawkColors.YellowPale.ContrastColor();

        public Color CriticalBackColor { get; set; } = HawkColors.Fail;

        public Color CriticalForeColor { get; set; } = HawkColors.Fail.ContrastColor();

        public Color SuccessBackColor { get; set; } = HawkColors.Success;

        public Color SuccessForeColor { get; set; } = HawkColors.Success.ContrastColor();

        public Color NotApplicableBackColor { get; set; } = HawkColors.NotApplicable;

        public Color NotApplicableForeColor { get; set; } = HawkColors.HawkBlueDark;

        public Color AcknowledgedBackColor { get; set; } = HawkColors.BlueLight;

        public Color AcknowledgedForeColor { get; set; } = HawkColors.BlueLight.ContrastColor();

        public Color InformationBackColor { get; set; } = HawkColors.Information;
        public Color InformationForeColor { get; set; } = HawkColors.Information.ContrastColor();

        public Color DisabledBackColor { get; set; } = HawkColors.Gray3;

        public Color DisabledForeColor { get; set; } = HawkColors.Gray3.ContrastColor();

        public Color SearchBackColor { get; set; } = HawkColors.GrayLight;

        public Color TimeZoneBackColor { get; set; } = HawkColors.HawkBlue;

        public Color TimeZoneForeColor { get; set; } = Color.White;

        public Color TitleBackColor { get; set; } = HawkColors.HawkBlueDark;

        public Color TitleForeColor { get; set; } = Color.White;

        public Color TimelineTitleForeColor { get; set; } = HawkColors.White;

        public Color TimelineTitleBackColor { get; set; } = HawkColors.HawkBlueDark;

        public Color TimelineBodyBackColor { get; set; } = HawkColors.GrayLight;

        public Color TimelineBodyForeColor { get; set; } = Color.Black;

        public Color TimelineLabelColor { get; set; } = HawkColors.HawkBlueDark;

        public Color TimelineChartBackColor { get; set; } = HawkColors.GrayLight;

        public Color TimelineGridColor { get; set; } = HawkColors.HawkBlueDark;

        public Color TimelineToolTipBackColor { get; set; } = HawkColors.HawkBlue;

        public Color TimelineToolTipForeColor { get; set; } = HawkColors.White;

        public Color PanelBackColor { get; set; } = SystemColors.Control;

        public Color PanelForeColor { get; set; } = SystemColors.ControlText;

        public Color ButtonBackColor { get; set; } = HawkColors.HawkBlueDark;

        public Color ButtonForeColor { get; set; } = Color.White;

        public Color ButtonBorderColor { get; set; } = HawkColors.HawkBlue;

        public Color TreeViewBackColor { get; set; } = HawkColors.GrayLight;

        public Color TreeViewForeColor { get; set; } = HawkColors.HawkBlueDark;

        public Color ColumnHeaderBackColor { get; set; } = HawkColors.HawkBlueDark;

        public Color ColumnHeaderForeColor { get; set; } = HawkColors.White;

        public Color CodeEditorBackColor { get; set; } = HawkColors.GrayLight;

        public Color CodeEditorForeColor { get; set; } = Color.Black;

        public Color TabHeaderBackColor { get; set; } = HawkColors.HawkBlueDark;

        public Color TabHeaderForeColor { get; set; } = HawkColors.White;

        public Color SelectedTabBackColor { get; set; } = HawkColors.BlueLight;

        public Color SelectedTabForeColor { get; set; } = HawkColors.White;

        public Color TabBackColor { get; set; } = HawkColors.Gray0;

        public Color TabBorderColor { get; set; } = Color.Black;

        public Color InputBackColor { get; set; } = HawkColors.White;

        public Color InputForeColor { get; set; } = HawkColors.HawkBlueDark;

        public Color InputDisabledBackColor { get; set; } = HawkColors.GrayLight;
    }
}