// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class GetServiceRecordResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetServiceRecordResponseBodyResult Result { get; set; }
        public class GetServiceRecordResponseBodyResult : TeaModel {
            [NameInMap("customerId")]
            [Validation(Required=false)]
            public string CustomerId { get; set; }

            [NameInMap("deviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            [NameInMap("endTimestamp")]
            [Validation(Required=false)]
            public long? EndTimestamp { get; set; }

            [NameInMap("outBizData")]
            [Validation(Required=false)]
            public string OutBizData { get; set; }

            [NameInMap("qualityInspectionScore")]
            [Validation(Required=false)]
            public int? QualityInspectionScore { get; set; }

            [NameInMap("recordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }

            [NameInMap("startTimestamp")]
            [Validation(Required=false)]
            public long? StartTimestamp { get; set; }

            [NameInMap("team")]
            [Validation(Required=false)]
            public GetServiceRecordResponseBodyResultTeam Team { get; set; }
            public class GetServiceRecordResponseBodyResultTeam : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("user")]
            [Validation(Required=false)]
            public GetServiceRecordResponseBodyResultUser User { get; set; }
            public class GetServiceRecordResponseBodyResultUser : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }

        }

    }

}
