// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class UpdateInteractiveOTOMessageResponseBody : TeaModel {
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
        public UpdateInteractiveOTOMessageResponseBodyResult Result { get; set; }
        public class UpdateInteractiveOTOMessageResponseBodyResult : TeaModel {
            [NameInMap("openPushId")]
            [Validation(Required=false)]
            public string OpenPushId { get; set; }
        };

    }

}
