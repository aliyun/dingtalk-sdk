// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryGroupMemberByMemberAuthResponseBody : TeaModel {
        /// <summary>
        /// 群成员列表
        /// </summary>
        [NameInMap("groupMemberList")]
        [Validation(Required=false)]
        public List<QueryGroupMemberByMemberAuthResponseBodyGroupMemberList> GroupMemberList { get; set; }
        public class QueryGroupMemberByMemberAuthResponseBodyGroupMemberList : TeaModel {
            /// <summary>
            /// 群内昵称
            /// 
            /// </summary>
            [NameInMap("groupNickName")]
            [Validation(Required=false)]
            public string GroupNickName { get; set; }

            /// <summary>
            /// 企业内成员姓名
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// 头像url
            /// </summary>
            [NameInMap("profilePhotoUrl")]
            [Validation(Required=false)]
            public string ProfilePhotoUrl { get; set; }

            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
