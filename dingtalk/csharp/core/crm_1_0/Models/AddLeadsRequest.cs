// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AddLeadsRequest : TeaModel {
        [NameInMap("assignTimestamp")]
        [Validation(Required=false)]
        public long? AssignTimestamp { get; set; }

        [NameInMap("assignUserId")]
        [Validation(Required=false)]
        public string AssignUserId { get; set; }

        [NameInMap("assignedUserId")]
        [Validation(Required=false)]
        public string AssignedUserId { get; set; }

        [NameInMap("leads")]
        [Validation(Required=false)]
        public List<AddLeadsRequestLeads> Leads { get; set; }
        public class AddLeadsRequestLeads : TeaModel {
            [NameInMap("leadsName")]
            [Validation(Required=false)]
            public string LeadsName { get; set; }

            [NameInMap("outLeadsId")]
            [Validation(Required=false)]
            public string OutLeadsId { get; set; }

        }

        [NameInMap("outTaskId")]
        [Validation(Required=false)]
        public string OutTaskId { get; set; }

    }

}
