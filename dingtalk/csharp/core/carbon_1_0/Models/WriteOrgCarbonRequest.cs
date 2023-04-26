// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteOrgCarbonRequest : TeaModel {
        [NameInMap("orgDetailsList")]
        [Validation(Required=false)]
        public List<WriteOrgCarbonRequestOrgDetailsList> OrgDetailsList { get; set; }
        public class WriteOrgCarbonRequestOrgDetailsList : TeaModel {
            [NameInMap("actionId")]
            [Validation(Required=false)]
            public string ActionId { get; set; }

            [NameInMap("actionTime")]
            [Validation(Required=false)]
            public string ActionTime { get; set; }

            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            [NameInMap("carbonAmount")]
            [Validation(Required=false)]
            public string CarbonAmount { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
