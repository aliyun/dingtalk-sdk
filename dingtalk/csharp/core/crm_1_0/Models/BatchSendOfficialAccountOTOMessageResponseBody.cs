// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class BatchSendOfficialAccountOTOMessageResponseBody : TeaModel {
        /// <summary>
        /// 开放API
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchSendOfficialAccountOTOMessageResponseBodyResult Result { get; set; }
        public class BatchSendOfficialAccountOTOMessageResponseBodyResult : TeaModel {
            [NameInMap("openPushId")]
            [Validation(Required=false)]
            public string OpenPushId { get; set; }
        };

    }

}
