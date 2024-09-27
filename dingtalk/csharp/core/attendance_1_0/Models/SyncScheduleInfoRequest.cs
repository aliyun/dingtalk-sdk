// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class SyncScheduleInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("scheduleInfos")]
        [Validation(Required=false)]
        public List<SyncScheduleInfoRequestScheduleInfos> ScheduleInfos { get; set; }
        public class SyncScheduleInfoRequestScheduleInfos : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public long? PlanId { get; set; }

            [NameInMap("positionKeys")]
            [Validation(Required=false)]
            public List<string> PositionKeys { get; set; }

            [NameInMap("retainAttendanceCheck")]
            [Validation(Required=false)]
            public bool? RetainAttendanceCheck { get; set; }

            [NameInMap("wifiKeys")]
            [Validation(Required=false)]
            public List<string> WifiKeys { get; set; }

        }

    }

}
