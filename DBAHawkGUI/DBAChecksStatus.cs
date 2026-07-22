using System;
using System.Drawing;

namespace DBAHawkGUI
{
    public class DBADashStatus
    {
        public enum DBADashStatusEnum
        {
            Critical = 1,
            Warning = 2,
            NA = 3,
            OK = 4,
            Acknowledged = 5,
            WarningLow = 6,
            Information = 7,
            Disabled = 8
        }

        public static Color GetStatusBackColor(DBADashStatusEnum status)
        {
            return status switch
            {
                DBADashStatusEnum.Critical => DBADashUser.SelectedTheme.CriticalBackColor,
                DBADashStatusEnum.Warning => DBADashUser.SelectedTheme.WarningBackColor,
                DBADashStatusEnum.NA => DBADashUser.SelectedTheme.NotApplicableBackColor,
                DBADashStatusEnum.OK => DBADashUser.SelectedTheme.SuccessBackColor,
                DBADashStatusEnum.Acknowledged => DBADashUser.SelectedTheme.AcknowledgedBackColor,
                DBADashStatusEnum.WarningLow => DBADashUser.SelectedTheme.WarningLowBackColor,
                DBADashStatusEnum.Information => DBADashUser.SelectedTheme.InformationBackColor,
                DBADashStatusEnum.Disabled => DBADashUser.SelectedTheme.DisabledBackColor,
                _ => HawkColors.RedPale
            };
        }

        public static Color GetStatusForeColor(DBADashStatusEnum status)
        {
            return status switch
            {
                DBADashStatusEnum.Critical => DBADashUser.SelectedTheme.CriticalForeColor,
                DBADashStatusEnum.Warning => DBADashUser.SelectedTheme.WarningForeColor,
                DBADashStatusEnum.NA => DBADashUser.SelectedTheme.NotApplicableForeColor,
                DBADashStatusEnum.OK => DBADashUser.SelectedTheme.SuccessForeColor,
                DBADashStatusEnum.Acknowledged => DBADashUser.SelectedTheme.AcknowledgedForeColor,
                DBADashStatusEnum.WarningLow => DBADashUser.SelectedTheme.WarningLowForeColor,
                DBADashStatusEnum.Information => DBADashUser.SelectedTheme.InformationForeColor,
                DBADashStatusEnum.Disabled => DBADashUser.SelectedTheme.DisabledForeColor,
                _ => HawkColors.RedPale
            };
        }

        public static DBADashStatusEnum? ConvertToDBADashStatusEnum(int value)
        {
            if (Enum.IsDefined(typeof(DBADashStatusEnum), value))
            {
                return (DBADashStatusEnum)value;
            }
            else
            {
                return null;
            }
        }

        public static void SetProgressBarColor(DBADashStatusEnum status, ref CustomProgressControl.DataGridViewProgressBarCell pCell)
        {
            if (status == DBADashStatusEnum.OK)
            {
                pCell.ProgressBarColorFrom = HawkColors.GreenPale;
                pCell.ProgressBarColorTo = HawkColors.Green;
            }
            else if (status == DBADashStatusEnum.Warning)
            {
                pCell.ProgressBarColorFrom = HawkColors.YellowPale;
                pCell.ProgressBarColorTo = HawkColors.YellowDark;
            }
            else if (status == DBADashStatusEnum.Critical)
            {
                pCell.ProgressBarColorFrom = HawkColors.RedPale;
                pCell.ProgressBarColorTo = HawkColors.RedDark;
            }
            else
            {
                pCell.ProgressBarColorFrom = HawkColors.ProgressBarFrom;
                pCell.ProgressBarColorTo = HawkColors.ProgressBarTo;
            }
        }
    }
}