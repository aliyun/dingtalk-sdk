// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentUserInfosResponseBody : TeaModel {
        /// <summary>
        /// 员工信息列表
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<ListResidentUserInfosResponseBodyUserList> UserList { get; set; }
        public class ListResidentUserInfosResponseBodyUserList : TeaModel {
            /// <summary>
            /// 员工特征
            /// </summary>
            [NameInMap("feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// 标签列表
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListResidentUserInfosResponseBodyUserListRoles> Roles { get; set; }
            public class ListResidentUserInfosResponseBodyUserListRoles : TeaModel {
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
            /// 员工 ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 员工名字
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
