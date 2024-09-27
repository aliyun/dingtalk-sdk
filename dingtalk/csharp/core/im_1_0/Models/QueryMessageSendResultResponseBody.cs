// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryMessageSendResultResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryMessageSendResultResponseBodyResult Result { get; set; }
        public class QueryMessageSendResultResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>msghcuh234</para>
            /// </summary>
            [NameInMap("openMessageId")]
            [Validation(Required=false)]
            public string OpenMessageId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sendStatus")]
            [Validation(Required=false)]
            public int? SendStatus { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
