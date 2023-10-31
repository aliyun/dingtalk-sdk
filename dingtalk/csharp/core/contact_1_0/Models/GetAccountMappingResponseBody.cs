// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetAccountMappingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetAccountMappingResponseBodyResult Result { get; set; }
        public class GetAccountMappingResponseBodyResult : TeaModel {
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extension { get; set; }

            [NameInMap("outId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            [NameInMap("outTenantId")]
            [Validation(Required=false)]
            public string OutTenantId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
