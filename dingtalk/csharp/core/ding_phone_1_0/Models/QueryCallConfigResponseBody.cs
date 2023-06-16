// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkding_phone_1_0.Models
{
    public class QueryCallConfigResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryCallConfigResponseBodyResult> Result { get; set; }
        public class QueryCallConfigResponseBodyResult : TeaModel {
            [NameInMap("accountDomain")]
            [Validation(Required=false)]
            public string AccountDomain { get; set; }

            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("callInType")]
            [Validation(Required=false)]
            public int? CallInType { get; set; }

            [NameInMap("callOutType")]
            [Validation(Required=false)]
            public int? CallOutType { get; set; }

            [NameInMap("createUid")]
            [Validation(Required=false)]
            public string CreateUid { get; set; }

            [NameInMap("phoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            [NameInMap("scopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            [NameInMap("showType")]
            [Validation(Required=false)]
            public int? ShowType { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
