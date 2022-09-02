// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryGroupMemberResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryGroupMemberResponseBodyResult Result { get; set; }
        public class QueryGroupMemberResponseBodyResult : TeaModel {
            /// <summary>
            /// 群成员列表
            /// </summary>
            [NameInMap("groupMemberList")]
            [Validation(Required=false)]
            public List<QueryGroupMemberResponseBodyResultGroupMemberList> GroupMemberList { get; set; }
            public class QueryGroupMemberResponseBodyResultGroupMemberList : TeaModel {
                /// <summary>
                /// 头像mediaId
                /// </summary>
                [NameInMap("avatarMediaId")]
                [Validation(Required=false)]
                public string AvatarMediaId { get; set; }

                /// <summary>
                /// 是否企业员工
                /// </summary>
                [NameInMap("isUser")]
                [Validation(Required=false)]
                public bool? IsUser { get; set; }

                /// <summary>
                /// 昵称
                /// </summary>
                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                /// <summary>
                /// 是否群主
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public bool? Owner { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                /// <summary>
                /// 企业员工id
                /// </summary>
                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// 群开放id
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
