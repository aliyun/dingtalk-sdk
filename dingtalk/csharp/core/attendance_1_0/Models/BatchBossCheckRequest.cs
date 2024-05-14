// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class BatchBossCheckRequest : TeaModel {
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<BatchBossCheckRequestModels> Models { get; set; }
        public class BatchBossCheckRequestModels : TeaModel {
            [NameInMap("absentMin")]
            [Validation(Required=false)]
            public long? AbsentMin { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public long? PlanId { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("timeResult")]
            [Validation(Required=false)]
            public string TimeResult { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
