﻿using ChartJs.Blazor.ChartJS.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartJs.Blazor.ChartJS.LineChart.Axes
{
    /// <summary>
    /// As per documentation here https://www.chartjs.org/docs/latest/axes/#common-configuration
    /// </summary>
    public abstract class Axis
    {
        /// <summary>
        /// Controls the axis global visibility (visible when <see cref="AxisDisplay.True"/>, hidden when <see cref="AxisDisplay.False"/>). 
        /// When display: <see cref="AxisDisplay.Auto"/>, the axis is visible only if at least one associated dataset is visible.
        /// </summary>
        public AxisDisplay Display { get; set; } = AxisDisplay.True;

        /// <summary>
        /// The weight used to sort the axis. Higher weights are further away from the chart area.
        /// </summary>
        public int? Weight { get; set; }

        // TODO: Maybe implement: https://www.chartjs.org/docs/latest/axes/#callbacks
        // public object Callbacks { get; set; }
    }
}
