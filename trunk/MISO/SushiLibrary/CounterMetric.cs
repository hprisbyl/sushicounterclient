﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SushiLibrary
{
    public class CounterMetric
    {
        public CounterMetricCategory Category { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public List<CounterMetricInstance> Instance { get; set; }

        public CounterMetric(DateTime start, DateTime end, CounterMetricCategory category)
        {
            Start = start;
            End = end;
            Category = category;
        }
    }

    public enum CounterMetricCategory
    {
        Requests,
        Searches,
        Sessions,
        Turnaways
    }
}