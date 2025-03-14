﻿using ChartJs.Blazor.ChartJS.Common.Enums;
using ChartJs.Blazor.ChartJS.Common.Properties;

namespace ChartJs.Blazor.ChartJS.LineChart
{
    // TODO: check if this would apply to more charts (https://www.chartjs.org/docs/latest/general/interactions) 
    // and if so rename and reuse this
    /// <summary>
    /// The hover-subconfig of <see cref="LineChartOptions"/>
    /// </summary>
    public class LineChartOptionsHover : Tooltips
    {
        /// <summary>
        /// Duration in milliseconds it takes to animate hover style changes.
        /// </summary>
        public long AnimationDuration { get; set; }
    }
}