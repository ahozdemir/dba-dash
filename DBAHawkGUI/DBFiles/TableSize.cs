using System;
using System.Windows.Forms;
using DBAHawkGUI.CustomReports;

namespace DBAHawkGUI.DBFiles
{
    public partial class TableSize : UserControl, ISetContext
    {
        public TableSize()
        {
            InitializeComponent();
        }

        public void SetContext(DBADashContext _context)
        {
            customReportView1.Report = _context.Type == SQLTreeItem.TreeType.Table ? TableSizeHistoryReport.Instance : TableSizeReport.Instance;
            customReportView1.SetContext(_context);
        }

        private void TableSize_Load(object sender, EventArgs e)
        {
        }
    }
}