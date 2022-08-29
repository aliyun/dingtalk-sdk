// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CreateIntegratedTaskResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CreateIntegratedTaskResponseBodyResult> Result { get; set; }
        public class CreateIntegratedTaskResponseBodyResult : TeaModel {
            /// <summary>
            /// OA审批任务ID
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// OA审批任务执行人用户ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 是否创建成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
