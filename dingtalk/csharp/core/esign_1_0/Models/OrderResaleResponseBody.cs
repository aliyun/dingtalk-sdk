// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class OrderResaleResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public OrderResaleResponseBodyData Data { get; set; }
        public class OrderResaleResponseBodyData : TeaModel {
            [NameInMap("esignOrderId")]
            [Validation(Required=false)]
            public string EsignOrderId { get; set; }
        };

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
