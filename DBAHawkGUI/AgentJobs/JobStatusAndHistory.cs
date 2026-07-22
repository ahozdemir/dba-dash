using System.Windows.Forms;

namespace DBAHawkGUI.AgentJobs
{
    public partial class JobStatusAndHistory : Form, ISetContext
    {
        public JobStatusAndHistory()
        {
            InitializeComponent();
        }

        public void SetContext(DBADashContext _context)
        {
            agentJobsControl1.SetContext(_context);
        }
    }
}
