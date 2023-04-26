// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncBusinessSignInfoRequest : TeaModel {
        [NameInMap("bizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        [NameInMap("gmtOrgPay")]
        [Validation(Required=false)]
        public string GmtOrgPay { get; set; }

        [NameInMap("gmtSign")]
        [Validation(Required=false)]
        public string GmtSign { get; set; }

        [NameInMap("orgPayStatus")]
        [Validation(Required=false)]
        public string OrgPayStatus { get; set; }

        [NameInMap("signStatus")]
        [Validation(Required=false)]
        public string SignStatus { get; set; }

        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

    }

}
