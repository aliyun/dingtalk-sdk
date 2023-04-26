// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class AssignOrgHoldingToEmpHoldingBatchRequest : TeaModel {
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("sendOrgCultureInform")]
        [Validation(Required=false)]
        public bool? SendOrgCultureInform { get; set; }

        [NameInMap("singleAmount")]
        [Validation(Required=false)]
        public long? SingleAmount { get; set; }

        [NameInMap("sourceUsage")]
        [Validation(Required=false)]
        public string SourceUsage { get; set; }

        [NameInMap("targetUsage")]
        [Validation(Required=false)]
        public string TargetUsage { get; set; }

        [NameInMap("targetUserList")]
        [Validation(Required=false)]
        public List<AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList> TargetUserList { get; set; }
        public class AssignOrgHoldingToEmpHoldingBatchRequestTargetUserList : TeaModel {
            [NameInMap("outId")]
            [Validation(Required=false)]
            public string OutId { get; set; }

            [NameInMap("targetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

        }

    }

}
