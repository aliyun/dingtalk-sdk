// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetBranchAuthDataRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public Dictionary<string, string> Body { get; set; }

        [NameInMap("branchCorpId")]
        [Validation(Required=false)]
        public string BranchCorpId { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
