// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class ContractMarginResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ContractMarginResponseBodyData Data { get; set; }
        public class ContractMarginResponseBodyData : TeaModel {
            [NameInMap("margin")]
            [Validation(Required=false)]
            public long? Margin { get; set; }
        };

        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
