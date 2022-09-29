// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class InstallAppResponseBody : TeaModel {
        /// <summary>
        /// 返回对象列表
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<InstallAppResponseBodyResult> Result { get; set; }
        public class InstallAppResponseBodyResult : TeaModel {
            /// <summary>
            /// 套件业务类型
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// 模版名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 模版processcode
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
