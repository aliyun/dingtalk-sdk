// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskTaskflowstatusResponseBody : TeaModel {
        /// <summary>
        /// 结果。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateTaskTaskflowstatusResponseBodyResult Result { get; set; }
        public class UpdateTaskTaskflowstatusResponseBodyResult : TeaModel {
            /// <summary>
            /// 更新时间。
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
