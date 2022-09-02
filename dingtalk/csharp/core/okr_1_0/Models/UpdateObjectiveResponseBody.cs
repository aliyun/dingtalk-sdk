// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateObjectiveResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateObjectiveResponseBodyData Data { get; set; }
        public class UpdateObjectiveResponseBodyData : TeaModel {
            /// <summary>
            /// 当前 Objective ID。
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 当前 Objective 的位置。
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public float? Position { get; set; }

        }

        /// <summary>
        /// 请求成功的标识。
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
