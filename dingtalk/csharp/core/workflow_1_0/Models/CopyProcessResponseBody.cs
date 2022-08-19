// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CopyProcessResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CopyProcessResponseBodyResult> Result { get; set; }
        public class CopyProcessResponseBodyResult : TeaModel {
            /// <summary>
            /// 业务标识
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// 模板名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 模板code
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
