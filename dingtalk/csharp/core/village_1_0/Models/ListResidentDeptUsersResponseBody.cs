// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentDeptUsersResponseBody : TeaModel {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一个游标
        /// </summary>
        [NameInMap("nextCursor")]
        [Validation(Required=false)]
        public long? NextCursor { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<ListResidentDeptUsersResponseBodyUserList> UserList { get; set; }
        public class ListResidentDeptUsersResponseBodyUserList : TeaModel {
            /// <summary>
            /// 员工特征
            /// </summary>
            [NameInMap("feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// 员工名字
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 标签列表
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListResidentDeptUsersResponseBodyUserListRoles> Roles { get; set; }
            public class ListResidentDeptUsersResponseBodyUserListRoles : TeaModel {
                /// <summary>
                /// 标签名称 tagCode
                /// </summary>
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                /// <summary>
                /// 标签id
                /// </summary>
                [NameInMap("tagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                /// <summary>
                /// 标签名称
                /// </summary>
                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// 钉钉唯一标识
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 员工id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
