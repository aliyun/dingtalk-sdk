// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryClueFollowStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryClueFollowStatusResponseBodyResult> Result { get; set; }
        public class QueryClueFollowStatusResponseBodyResult : TeaModel {
            [NameInMap("clueId")]
            [Validation(Required=false)]
            public string ClueId { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
