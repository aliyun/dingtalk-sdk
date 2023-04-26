// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class GetPeriodListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPeriodListResponseBodyData Data { get; set; }
        public class GetPeriodListResponseBodyData : TeaModel {
            [NameInMap("periodList")]
            [Validation(Required=false)]
            public List<GetPeriodListResponseBodyDataPeriodList> PeriodList { get; set; }
            public class GetPeriodListResponseBodyDataPeriodList : TeaModel {
                [NameInMap("endTime")]
                [Validation(Required=false)]
                public float? EndTime { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public Stream Id { get; set; }

                [NameInMap("isCurrent")]
                [Validation(Required=false)]
                public bool? IsCurrent { get; set; }

                [NameInMap("isYearly")]
                [Validation(Required=false)]
                public bool? IsYearly { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public Stream Name { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public float? StartTime { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
