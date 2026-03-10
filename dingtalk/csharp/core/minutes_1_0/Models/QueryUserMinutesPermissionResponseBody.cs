// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkminutes_1_0.Models
{
    public class QueryUserMinutesPermissionResponseBody : TeaModel {
        [NameInMap("hasPermission")]
        [Validation(Required=false)]
        public bool? HasPermission { get; set; }

        /// <summary>
        /// <para>角色类型：manager-管理员, owner-所有者, editor-可编辑, read_download-可查看/下载, read-仅查看, none-无权限</para>
        /// </summary>
        [NameInMap("roleType")]
        [Validation(Required=false)]
        public string RoleType { get; set; }

    }

}
