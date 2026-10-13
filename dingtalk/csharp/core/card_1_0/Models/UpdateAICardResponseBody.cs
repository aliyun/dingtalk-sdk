// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcard_1_0.Models
{
    public class UpdateAICardResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public UpdateAICardResponseBodyResult Result { get; set; }
        public class UpdateAICardResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>FINISH</para>
            /// </summary>
            [NameInMap("flowStatus")]
            [Validation(Required=false)]
            public string FlowStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a2ui_order_001</para>
            /// </summary>
            [NameInMap("outTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>update_001</para>
            /// </summary>
            [NameInMap("outUpdateId")]
            [Validation(Required=false)]
            public string OutUpdateId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
