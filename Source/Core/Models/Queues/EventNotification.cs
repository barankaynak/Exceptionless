﻿using System;
using Exceptionless.Core.Utility;
using Exceptionless.Core.Models;

namespace Exceptionless.Core.Queues.Models {
    public class EventNotification : ExtensibleObject {
        public PersistentEvent Event { get; set; }
        public bool IsNew { get; set; }
        public bool IsCritical { get; set; }
        public bool IsRegression { get; set; }
        public int TotalOccurrences { get; set; }
        public string ProjectName { get; set; }
    }
}