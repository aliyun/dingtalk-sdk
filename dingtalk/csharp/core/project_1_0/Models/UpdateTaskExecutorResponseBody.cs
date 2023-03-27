// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskExecutorResponseBody : TeaModel {
        /// <summary>
        /// 结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskExecutorResponseBodyResult Result { get; set; }
        public class UpdateTaskExecutorResponseBodyResult : TeaModel {
            /// <summary>
            /// 执行者用户ID。
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
