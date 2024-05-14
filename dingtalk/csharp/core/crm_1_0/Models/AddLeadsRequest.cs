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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("assignUserId")]
        [Validation(Required=false)]
        public string AssignUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("assignedUserId")]
        [Validation(Required=false)]
        public string AssignedUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("leads")]
        [Validation(Required=false)]
        public List<AddLeadsRequestLeads> Leads { get; set; }
        public class AddLeadsRequestLeads : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("leadsName")]
            [Validation(Required=false)]
            public string LeadsName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("outLeadsId")]
            [Validation(Required=false)]
            public string OutLeadsId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outTaskId")]
        [Validation(Required=false)]
        public string OutTaskId { get; set; }

    }

}
