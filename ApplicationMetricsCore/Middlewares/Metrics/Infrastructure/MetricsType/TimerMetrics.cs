﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationMetricsCore.Middlewares.Metrics.Infrastructure.MetricsType
{
    public class TimerMetrics
    {
        private static Stopwatch _stopwatchRequest { get; set; }
        private static Stopwatch _stopwatchResponse { get; set; }

        public static long RequestTime => _stopwatchRequest.ElapsedMilliseconds;
        public static long ResponseTime => _stopwatchResponse.ElapsedMilliseconds;

        public static void StartRequest() => _stopwatchRequest = Stopwatch.StartNew();
        public static void StopRequest() => _stopwatchRequest.Stop();

        public static void StartResponse() => _stopwatchResponse = Stopwatch.StartNew();
        public static void StopResponse() => _stopwatchResponse.Stop();
    }
}
