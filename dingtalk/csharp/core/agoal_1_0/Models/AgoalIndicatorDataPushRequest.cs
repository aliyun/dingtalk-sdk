// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkagoal_1_0.Models
{
    public class AgoalIndicatorDataPushRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>code_sik2834jdi383jd</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<AgoalIndicatorDataPushRequestData> Data { get; set; }
        public class AgoalIndicatorDataPushRequestData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("data")]
            [Validation(Required=false)]
            public string Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-11-01 11:01:00</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>YEAR、HALF_YEAR、QUARTER、DOUBLE_MONTH、MONTH、WEEK</para>
            /// </summary>
            [NameInMap("periodType")]
            [Validation(Required=false)]
            public string PeriodType { get; set; }

        }

    }

}
