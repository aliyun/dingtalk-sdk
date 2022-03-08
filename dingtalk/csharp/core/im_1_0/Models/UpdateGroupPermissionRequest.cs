// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class UpdateGroupPermissionRequest : TeaModel {
        /// <summary>
        /// 开放群ID
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 群权限项
        /// </summary>
        [NameInMap("permissionGroup")]
        [Validation(Required=false)]
        public string PermissionGroup { get; set; }

        /// <summary>
        /// 状态,0-关闭，1-开启
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
