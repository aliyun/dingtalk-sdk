// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupManageQueryResponseBody : TeaModel {
        [NameInMap("groupInfoList")]
        [Validation(Required=false)]
        public List<GroupManageQueryResponseBodyGroupInfoList> GroupInfoList { get; set; }
        public class GroupManageQueryResponseBodyGroupInfoList : TeaModel {
            [NameInMap("banWordsMode")]
            [Validation(Required=false)]
            public int? BanWordsMode { get; set; }

            [NameInMap("capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtInfo { get; set; }

            [NameInMap("groupAdminList")]
            [Validation(Required=false)]
            public List<string> GroupAdminList { get; set; }

            [NameInMap("groupOwner")]
            [Validation(Required=false)]
            public string GroupOwner { get; set; }

            [NameInMap("groupTitle")]
            [Validation(Required=false)]
            public string GroupTitle { get; set; }

            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
