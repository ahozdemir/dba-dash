using DBAHawk.Messaging;

namespace DBAHawkGUI.CommunityTools
{
    public class SystemDirectExecutionReport : DirectExecutionReport
    {
        public ProcedureExecutionMessage.EmbeddedScripts EmbeddedScript { get; set; }

        public override string ProcedureName => string.Empty;

        public override string SchemaName => string.Empty;
    }
}