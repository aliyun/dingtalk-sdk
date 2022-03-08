// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class UpdateGroupTagRequest : TeaModel {
        /// <summary>
        /// 群会话ID集合
        /// </summary>
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public List<string> OpenConversationIds { get; set; }

        [NameInMap("tagNames")]
        [Validation(Required=false)]
        public List<string> TagNames { get; set; }

        /// <summary>
        /// 更新类型，APPEND、NOTAPPEND、DELETE三种类型
        /// </summary>
        [NameInMap("updateType")]
        [Validation(Required=false)]
        public string UpdateType { get; set; }

    }

}
