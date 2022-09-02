// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// 返回对象
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateOrganizationTaskStatusResponseBodyResult Result { get; set; }
        public class UpdateOrganizationTaskStatusResponseBodyResult : TeaModel {
            /// <summary>
            /// 是否已完成
            /// </summary>
            [NameInMap("isDone")]
            [Validation(Required=false)]
            public bool? IsDone { get; set; }

            /// <summary>
            /// 更新时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
