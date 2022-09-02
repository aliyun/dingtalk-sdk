// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendInteractiveOTOMessageResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 推送结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public SendInteractiveOTOMessageResponseBodyResult Result { get; set; }
        public class SendInteractiveOTOMessageResponseBodyResult : TeaModel {
            /// <summary>
            /// 推送ID
            /// </summary>
            [NameInMap("openPushId")]
            [Validation(Required=false)]
            public string OpenPushId { get; set; }

        }

    }

}
