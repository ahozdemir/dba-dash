using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBAHawk.Messaging;

namespace DBAHawkGUI.AgentJobs
{
    internal class HelpJobInfoExtended : HelpJobInfo
    {
        public Color LastRunOutcomeColor => GetLastRunOutcomeColor(LastRunOutcome);

        public static Color GetLastRunOutcomeColor(int? value)
        {
            return value switch
            {
                0 => HawkColors.Fail,
                1 => HawkColors.Success,
                3 => HawkColors.Warning,
                5 => HawkColors.AvoidanceZone,
                _ => HawkColors.AvoidanceZone
            };
        }

        public HelpJobInfoExtended(DataTable dtJob) : base(dtJob)
        {
        }
    }
}