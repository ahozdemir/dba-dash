using DBAHawkGUI.Performance;
using static DBAHawkGUI.Performance.IMetric;

namespace DBAHawkGUI
{
    /// <summary>
    /// Used to store the state of the Blocking chart
    /// </summary>
    public class BlockingMetric : IMetric
    {
        public MetricTypes MetricType => MetricTypes.Blocking;

        public bool BlockingSnapshots { get; set; } = true;

        public bool Deadlocks { get; set; } = true;

        public IMetricChart GetChart()
        {
            return new Blocking() { Metric = this };
        }
    }
}