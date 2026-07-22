using System;
using System.Windows.Forms;
using DBAHawkGUI.Theme;

namespace DBAHawkGUI.Performance
{
    public partial class WaitSummaryDialog : Form, ISetContext
    {
        public WaitSummaryDialog()
        {
            InitializeComponent();
            this.ApplyTheme();
        }

        DBADashContext context;

        public void SetContext(DBADashContext _context)
        {
            this.context = _context; 
        }

        private void WaitSummaryDialog_Load(object sender, EventArgs e)
        {
            waitsSummary1.SetContext(context); // Set Context on load for auto resize to work
        }
    }
}
