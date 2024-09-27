// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class SaveIntegratedInstanceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public SaveIntegratedInstanceResponseBodyResult Result { get; set; }
        public class SaveIntegratedInstanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>proc-abc</para>
            /// </summary>
            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

        }

    }

}
