// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class MultiOrgPermissionGrantRequest : TeaModel {
        [NameInMap("grantDeptIdList")]
        [Validation(Required=false)]
        public List<long?> GrantDeptIdList { get; set; }

        [NameInMap("joinCorpId")]
        [Validation(Required=false)]
        public string JoinCorpId { get; set; }

    }

}
