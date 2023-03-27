// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskDueDateResponseBody : TeaModel {
        /// <summary>
        /// 结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskDueDateResponseBodyResult Result { get; set; }
        public class UpdateTaskDueDateResponseBodyResult : TeaModel {
            /// <summary>
            /// 截止时间。
            /// </summary>
            [NameInMap("dueDate")]
            [Validation(Required=false)]
            public string DueDate { get; set; }

            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
