// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskContentResponseBody : TeaModel {
        /// <summary>
        /// 结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskContentResponseBodyResult Result { get; set; }
        public class UpdateTaskContentResponseBodyResult : TeaModel {
            /// <summary>
            /// 任务标题。
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
