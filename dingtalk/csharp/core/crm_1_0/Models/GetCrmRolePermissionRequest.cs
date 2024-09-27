// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCrmRolePermissionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>crm_customer</para>
        /// </summary>
        [NameInMap("bizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PROC-9EC85C45-E404-4E26-9300-E67455F0FF8F</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
