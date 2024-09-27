// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcarbon_1_0.Models
{
    public class WriteAlibabaOrgCarbonRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("orgDetailsList")]
        [Validation(Required=false)]
        public List<WriteAlibabaOrgCarbonRequestOrgDetailsList> OrgDetailsList { get; set; }
        public class WriteAlibabaOrgCarbonRequestOrgDetailsList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12320211126</para>
            /// </summary>
            [NameInMap("actionId")]
            [Validation(Required=false)]
            public string ActionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-26 10:09:37</para>
            /// </summary>
            [NameInMap("actionTime")]
            [Validation(Required=false)]
            public string ActionTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VIDEO</para>
            /// </summary>
            [NameInMap("actionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.21</para>
            /// </summary>
            [NameInMap("carbonAmount")]
            [Validation(Required=false)]
            public string CarbonAmount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ding12344</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
