using System;
using System.Windows.Forms;
using DBAHawkGUI.Theme;

namespace DBAHawkGUI.Drives
{
    public partial class DriveHistoryView : Form
    {
        public DriveHistoryView()
        {
            InitializeComponent();
            this.ApplyTheme();
        }

        public string ConnectionString;
        public int DriveID;

        private void DriveHistoryView_Load(object sender, EventArgs e)
        {
            driveHistory1.DriveID = DriveID;
            driveHistory1.RefreshData();
        }
    }
}
