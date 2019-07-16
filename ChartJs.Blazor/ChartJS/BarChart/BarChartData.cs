using System.Collections.Generic;
using ChartJs.Blazor.ChartJS.BarChart.Dataset;
using ChartJs.Blazor.ChartJS.MixedChart;

namespace ChartJs.Blazor.ChartJS.BarChart
{
    /// <summary>
    /// The data-subconfig of a <see cref="BarChartConfig"/>
    /// </summary>
    public class BarChartData
    {
        /// <summary>
        /// The labels the chart will use. 
        /// <para>If defined (not null) the x-Axis has to be of type <see cref="Common.Enums.AxisType.Category"/> for the chart to work correctly. 
        /// You can also you a <see cref="LineChart.Axes.TimeAxis"/> with <see cref="LineChart.TimeTupel{TData}"/> instead of defining labels.</para>
        /// </summary>
        public List<string> Labels { get; set; }

        /// <summary>
        /// The Datasets displayed in this chart.
        /// </summary>
        public HashSet<IMixableDataset<object>> Datasets { get; }
    }
}
