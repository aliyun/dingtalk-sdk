// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateInviteUrlRequest : TeaModel {
        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOauthAppId")]
        [Validation(Required=false)]
        public long? DingOauthAppId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public int? DingTokenGrantType { get; set; }

        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("targetOperator")]
        [Validation(Required=false)]
        public string TargetOperator { get; set; }

    }

}
