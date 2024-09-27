// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class AppendRolePermissionShrinkRequest : TeaModel {
        [NameInMap("rolePermissionItemList")]
        [Validation(Required=false)]
        public string RolePermissionItemListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5041234</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
