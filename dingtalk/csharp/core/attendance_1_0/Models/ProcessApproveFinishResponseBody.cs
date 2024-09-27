// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkattendance_1_0.Models
{
    public class ProcessApproveFinishResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ProcessApproveFinishResponseBodyResult Result { get; set; }
        public class ProcessApproveFinishResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            [NameInMap("durationDetail")]
            [Validation(Required=false)]
            public List<ProcessApproveFinishResponseBodyResultDurationDetail> DurationDetail { get; set; }
            public class ProcessApproveFinishResponseBodyResultDurationDetail : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2019-08-15</para>
                /// </summary>
                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
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
