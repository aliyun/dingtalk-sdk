// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class CreateKeyResultResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateKeyResultResponseBodyData Data { get; set; }
        public class CreateKeyResultResponseBodyData : TeaModel {
            /// <summary>
            /// 创建成功的 KR ID。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public Stream Id { get; set; }

            /// <summary>
            /// KR的位置。
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public long? Position { get; set; }

            /// <summary>
            /// KR 的权重。
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        /// <summary>
        /// 请求成功的标识。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
