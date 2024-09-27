// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetProcessCodeByNameResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetProcessCodeByNameResponseBodyResult Result { get; set; }
        public class GetProcessCodeByNameResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-22T11:50Z</para>
            /// </summary>
            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PROC-abcdef-example</para>
            /// </summary>
            [NameInMap("processCode")]
            [Validation(Required=false)]
            public string ProcessCode { get; set; }

        }

    }

}
