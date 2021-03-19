// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetOfficialAccountContactInfoRequest : TeaModel {
        [NameInMap("context")]
        [Validation(Required=false)]
        public GetOfficialAccountContactInfoRequestContext Context { get; set; }
        public class GetOfficialAccountContactInfoRequestContext : TeaModel {
            [NameInMap("dingIsvOrgId")]
            [Validation(Required=false)]
            public long? DingIsvOrgId { get; set; }
            [NameInMap("dingOrgId")]
            [Validation(Required=false)]
            public long? DingOrgId { get; set; }
            [NameInMap("dingSuiteKey")]
            [Validation(Required=false)]
            public string DingSuiteKey { get; set; }
            [NameInMap("dingCorpId")]
            [Validation(Required=false)]
            public string DingCorpId { get; set; }
            [NameInMap("dingTokenGrantType")]
            [Validation(Required=false)]
            public long? DingTokenGrantType { get; set; }
            [NameInMap("dingClientId")]
            [Validation(Required=false)]
            public string DingClientId { get; set; }
            [NameInMap("dingOauthAppId")]
            [Validation(Required=false)]
            public long? DingOauthAppId { get; set; }
        };

    }

}
