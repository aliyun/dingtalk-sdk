// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class ListAccountResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListAccountResponseBodyResult> Result { get; set; }
        public class ListAccountResponseBodyResult : TeaModel {
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

        }

    }

}
