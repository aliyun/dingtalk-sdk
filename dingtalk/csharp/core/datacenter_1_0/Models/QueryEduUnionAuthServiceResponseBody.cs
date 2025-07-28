// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryEduUnionAuthServiceResponseBody : TeaModel {
        [NameInMap("authInfoModels")]
        [Validation(Required=false)]
        public List<QueryEduUnionAuthServiceResponseBodyAuthInfoModels> AuthInfoModels { get; set; }
        public class QueryEduUnionAuthServiceResponseBodyAuthInfoModels : TeaModel {
            [NameInMap("authCorpId")]
            [Validation(Required=false)]
            public string AuthCorpId { get; set; }

            [NameInMap("authCorpName")]
            [Validation(Required=false)]
            public string AuthCorpName { get; set; }

            [NameInMap("authTime")]
            [Validation(Required=false)]
            public string AuthTime { get; set; }

            [NameInMap("resourceNames")]
            [Validation(Required=false)]
            public List<string> ResourceNames { get; set; }

        }

    }

}
