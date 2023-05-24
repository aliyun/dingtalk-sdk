// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryGlobalInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryGlobalInfoResponseBodyResult Result { get; set; }
        public class QueryGlobalInfoResponseBodyResult : TeaModel {
            [NameInMap("oemEnable")]
            [Validation(Required=false)]
            public bool? OemEnable { get; set; }

        }

    }

}
