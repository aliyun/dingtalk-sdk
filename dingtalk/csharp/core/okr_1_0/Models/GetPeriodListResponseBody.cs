// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class GetPeriodListResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPeriodListResponseBodyData Data { get; set; }
        public class GetPeriodListResponseBodyData : TeaModel {
            [NameInMap("periodList")]
            [Validation(Required=false)]
            public List<GetPeriodListResponseBodyDataPeriodList> PeriodList { get; set; }
            public class GetPeriodListResponseBodyDataPeriodList : TeaModel {
                public float? EndTime { get; set; }
                public Stream Id { get; set; }
                public bool? IsCurrent { get; set; }
                public bool? IsYearly { get; set; }
                public Stream Name { get; set; }
                public float? StartTime { get; set; }
            }
        };

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
