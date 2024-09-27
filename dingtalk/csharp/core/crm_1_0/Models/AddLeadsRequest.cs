// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AddLeadsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1669360918000</para>
        /// </summary>
        [NameInMap("assignTimestamp")]
        [Validation(Required=false)]
        public long? AssignTimestamp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager1234</para>
        /// </summary>
        [NameInMap("assignUserId")]
        [Validation(Required=false)]
        public string AssignUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager1234</para>
        /// </summary>
        [NameInMap("assignedUserId")]
        [Validation(Required=false)]
        public string AssignedUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("leads")]
        [Validation(Required=false)]
        public List<AddLeadsRequestLeads> Leads { get; set; }
        public class AddLeadsRequestLeads : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XX公司</para>
            /// </summary>
            [NameInMap("leadsName")]
            [Validation(Required=false)]
            public string LeadsName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fasd123125</para>
            /// </summary>
            [NameInMap("outLeadsId")]
            [Validation(Required=false)]
            public string OutLeadsId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t123123123</para>
        /// </summary>
        [NameInMap("outTaskId")]
        [Validation(Required=false)]
        public string OutTaskId { get; set; }

    }

}
