// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class CalculateDurationResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CalculateDurationResponseBodyResult Result { get; set; }
        public class CalculateDurationResponseBodyResult : TeaModel {
            [NameInMap("duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            [NameInMap("durationDetail")]
            [Validation(Required=false)]
            public List<CalculateDurationResponseBodyResultDurationDetail> DurationDetail { get; set; }
            public class CalculateDurationResponseBodyResultDurationDetail : TeaModel {
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
