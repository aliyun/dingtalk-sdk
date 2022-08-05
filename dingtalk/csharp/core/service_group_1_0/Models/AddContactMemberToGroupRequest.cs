// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class AddContactMemberToGroupRequest : TeaModel {
        /// <summary>
        /// 员工unionId
        /// </summary>
        [NameInMap("memberUnionId")]
        [Validation(Required=false)]
        public string MemberUnionId { get; set; }

        /// <summary>
        /// 员工成员ID
        /// </summary>
        [NameInMap("memberUserId")]
        [Validation(Required=false)]
        public string MemberUserId { get; set; }

        /// <summary>
        /// 群会话ID
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
