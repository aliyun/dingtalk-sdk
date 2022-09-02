// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessCodeByNameResponseBody : TeaModel {
        /// <summary>
        /// 表单模板信息
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetProcessCodeByNameResponseBodyResult Result { get; set; }
        public class GetProcessCodeByNameResponseBodyResult : TeaModel {
            /// <summary>
            /// 保存或更新的表单code
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
