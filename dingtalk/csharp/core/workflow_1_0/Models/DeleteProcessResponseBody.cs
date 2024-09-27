// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class DeleteProcessResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DeleteProcessResponseBodyResult Result { get; set; }
        public class DeleteProcessResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>proc-abc</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
