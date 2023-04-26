// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SendInvitationRequest : TeaModel {
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public string DeptId { get; set; }

        [NameInMap("orgAlias")]
        [Validation(Required=false)]
        public string OrgAlias { get; set; }

        [NameInMap("partnerLabelId")]
        [Validation(Required=false)]
        public long? PartnerLabelId { get; set; }

        [NameInMap("partnerNum")]
        [Validation(Required=false)]
        public string PartnerNum { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

    }

}
