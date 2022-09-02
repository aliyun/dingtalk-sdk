// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UnAlignObjectiveResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UnAlignObjectiveResponseBodyData Data { get; set; }
        public class UnAlignObjectiveResponseBodyData : TeaModel {
            /// <summary>
            /// 对齐的 Objective ID。
            /// </summary>
            [NameInMap("alignId")]
            [Validation(Required=false)]
            public Stream AlignId { get; set; }

            /// <summary>
            /// 当前 Objective ID。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

        }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
