// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkoauth2_1_0.Models
{
    public class GetCorpAccessTokenRequest : TeaModel {
        [NameInMap("authCorpId")]
        [Validation(Required=false)]
        public string AuthCorpId { get; set; }

        [NameInMap("suiteKey")]
        [Validation(Required=false)]
        public string SuiteKey { get; set; }

        [NameInMap("suiteSecret")]
        [Validation(Required=false)]
        public string SuiteSecret { get; set; }

        [NameInMap("suiteTicket")]
        [Validation(Required=false)]
        public string SuiteTicket { get; set; }

    }

}
