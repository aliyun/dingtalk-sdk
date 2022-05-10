// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupManageQueryRequest : TeaModel {
        /// <summary>
        /// 群号
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 群成员样例工号列表
        /// </summary>
        [NameInMap("groupMemberSamples")]
        [Validation(Required=false)]
        public List<string> GroupMemberSamples { get; set; }

        /// <summary>
        /// 群主工号
        /// </summary>
        [NameInMap("groupOwner")]
        [Validation(Required=false)]
        public string GroupOwner { get; set; }

        /// <summary>
        /// 群标题关键词列表
        /// </summary>
        [NameInMap("groupTitleKeywords")]
        [Validation(Required=false)]
        public List<string> GroupTitleKeywords { get; set; }

        /// <summary>
        /// 群链接
        /// </summary>
        [NameInMap("groupUrl")]
        [Validation(Required=false)]
        public string GroupUrl { get; set; }

        /// <summary>
        /// 开放群id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

    }

}
