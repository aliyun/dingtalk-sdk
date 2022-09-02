// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class AlignObjectiveResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AlignObjectiveResponseBodyData Data { get; set; }
        public class AlignObjectiveResponseBodyData : TeaModel {
            /// <summary>
            /// 对齐目标的 ID。
            /// </summary>
            [NameInMap("alignId")]
            [Validation(Required=false)]
            public Stream AlignId { get; set; }

            /// <summary>
            /// 当前 Objective 的ID
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
