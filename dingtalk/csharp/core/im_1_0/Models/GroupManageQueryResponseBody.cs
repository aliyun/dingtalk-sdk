// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupManageQueryResponseBody : TeaModel {
        /// <summary>
        /// 群信息列表
        /// </summary>
        [NameInMap("groupInfoList")]
        [Validation(Required=false)]
        public List<GroupManageQueryResponseBodyGroupInfoList> GroupInfoList { get; set; }
        public class GroupManageQueryResponseBodyGroupInfoList : TeaModel {
            /// <summary>
            /// 群容量
            /// </summary>
            [NameInMap("capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            /// <summary>
            /// 群创建时间
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// 扩展信息
            /// </summary>
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtInfo { get; set; }

            /// <summary>
            /// 群主userid
            /// </summary>
            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public string GroupOwner { get; set; }

            /// <summary>
            /// 群标题
            /// </summary>
            [NameInMap("groupTitle")]
            [Validation(Required=false)]
            public string GroupTitle { get; set; }

            /// <summary>
            /// 当前群人数
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            /// <summary>
            /// 开放的群id
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

    }

}
