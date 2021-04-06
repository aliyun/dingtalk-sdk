// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class ModifyFeedWhiteListShrinkRequest : TeaModel {
        /// <summary>
        /// 用户id（操作者的组织内id）
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 操作类型（1 添加白名单 / 2 删除白名单）
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public long? Action { get; set; }

        /// <summary>
        /// 操作的白名单列表
        /// </summary>
        [NameInMap("modifyUserList")]
        [Validation(Required=false)]
        public string ModifyUserListShrink { get; set; }

    }

}
