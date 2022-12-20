// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AddLeadsRequest : TeaModel {
        /// <summary>
        /// 分配时间戳，如果不传则默认为当前时间。
        /// </summary>
        [NameInMap("assignTimestamp")]
        [Validation(Required=false)]
        public long? AssignTimestamp { get; set; }

        /// <summary>
        /// 分配线索的员工userId。
        /// </summary>
        [NameInMap("assignUserId")]
        [Validation(Required=false)]
        public string AssignUserId { get; set; }

        /// <summary>
        /// 被分配线索的员工userId。
        /// </summary>
        [NameInMap("assignedUserId")]
        [Validation(Required=false)]
        public string AssignedUserId { get; set; }

        /// <summary>
        /// 线索。
        /// </summary>
        [NameInMap("leads")]
        [Validation(Required=false)]
        public List<AddLeadsRequestLeads> Leads { get; set; }
        public class AddLeadsRequestLeads : TeaModel {
            /// <summary>
            /// 线索名称。
            /// </summary>
            [NameInMap("leadsName")]
            [Validation(Required=false)]
            public string LeadsName { get; set; }

            /// <summary>
            /// 线索id。
            /// </summary>
            [NameInMap("outLeadsId")]
            [Validation(Required=false)]
            public string OutLeadsId { get; set; }

        }

        /// <summary>
        /// 任务ID，用于幂等控制。
        /// </summary>
        [NameInMap("outTaskId")]
        [Validation(Required=false)]
        public string OutTaskId { get; set; }

    }

}
