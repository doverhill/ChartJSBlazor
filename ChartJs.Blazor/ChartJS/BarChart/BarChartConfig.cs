using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.ChartJS.Common.Enums;

namespace ChartJs.Blazor.ChartJS.BarChart
{
    /// <summary>
    /// Config for a bar chart
    /// <para>Either 'bar' or 'horizontalBar'</para>
    /// </summary>
    public class BarChartConfig : ChartConfigBase<BarChartOptions, BarChartData>
    {
        /// <summary>
        /// Creates a new instance of <see cref="BarChartConfig"/>
        /// </summary>
        /// <param name="type">Either <see cref="ChartTypes.Bar"/> (default) or <see cref="ChartTypes.HorizontalBar"/></param>
        public BarChartConfig(ChartTypes type = null) : base(type ?? ChartTypes.Bar) { }
    }
}