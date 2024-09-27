// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class AppendCustomerDataAuthRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("customerIds")]
        [Validation(Required=false)]
        public List<string> CustomerIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dataAuthUserIds")]
        [Validation(Required=false)]
        public List<string> DataAuthUserIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PROC-98187D45-EFC0-4FC4-887E-45BD24209D69</para>
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staffId2</para>
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crm_customer</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>owner</para>
        /// </summary>
        [NameInMap("roleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
