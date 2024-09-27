// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendAgentOTOMessageResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public SendAgentOTOMessageResponseBodyResult Result { get; set; }
        public class SendAgentOTOMessageResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("openPushId")]
            [Validation(Required=false)]
            public string OpenPushId { get; set; }

        }

    }

}
