using System.Windows.Forms;

namespace DBAHawkGUI.CustomReports
{
    public partial class ServerServices : UserControl, ISetContext
    {
        public ServerServices()
        {
            InitializeComponent();
        }

        public void SetContext(DBADashContext _context)
        {
            _context.Report = ServerServicesReport.Instance;
            customReportView1.SetContext(_context);
        }
    }
}