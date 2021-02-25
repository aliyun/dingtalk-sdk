// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class ChannelOrderResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public ChannelOrderResponseBodyData Data { get; set; }
        public class ChannelOrderResponseBodyData : TeaModel {
            [NameInMap("esignOrderId")]
            [Validation(Required=false)]
            public string EsignOrderId { get; set; }
        };

    }

}
