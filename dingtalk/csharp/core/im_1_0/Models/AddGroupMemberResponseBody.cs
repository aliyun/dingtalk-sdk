// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class AddGroupMemberResponseBody : TeaModel {
        /// <summary>
        /// 拉取成功的C端客户列表
        /// </summary>
        [NameInMap("appUserIds")]
        [Validation(Required=false)]
        public List<string> AppUserIds { get; set; }

        /// <summary>
        /// 拉取成功的B端客服列表
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
