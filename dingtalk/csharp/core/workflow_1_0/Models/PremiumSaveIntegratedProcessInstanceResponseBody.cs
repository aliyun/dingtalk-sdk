// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedProcessInstanceResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PremiumSaveIntegratedProcessInstanceResponseBodyResult Result { get; set; }
        public class PremiumSaveIntegratedProcessInstanceResponseBodyResult : TeaModel {
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
