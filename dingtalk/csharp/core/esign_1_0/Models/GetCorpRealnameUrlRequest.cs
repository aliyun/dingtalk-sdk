// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkesign_1_0.Models
{
    public class GetCorpRealnameUrlRequest : TeaModel {
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("dingIsvAccessToken")]
        [Validation(Required=false)]
        public string DingIsvAccessToken { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

    }

}
