// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvip_member_1_0.Models
{
    public class QueryRedeemVipMemberResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("queryResults")]
        [Validation(Required=false)]
        public List<QueryRedeemVipMemberResponseBodyQueryResults> QueryResults { get; set; }
        public class QueryRedeemVipMemberResponseBodyQueryResults : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("actionTime")]
            [Validation(Required=false)]
            public string ActionTime { get; set; }

            [NameInMap("dingtalkId")]
            [Validation(Required=false)]
            public string DingtalkId { get; set; }

            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("nick")]
            [Validation(Required=false)]
            public string Nick { get; set; }

        }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

    }

}
