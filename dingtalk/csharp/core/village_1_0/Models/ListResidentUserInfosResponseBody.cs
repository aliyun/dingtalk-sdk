// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkvillage_1_0.Models
{
    public class ListResidentUserInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userList")]
        [Validation(Required=false)]
        public List<ListResidentUserInfosResponseBodyUserList> UserList { get; set; }
        public class ListResidentUserInfosResponseBodyUserList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("roles")]
            [Validation(Required=false)]
            public List<ListResidentUserInfosResponseBodyUserListRoles> Roles { get; set; }
            public class ListResidentUserInfosResponseBodyUserListRoles : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("tagCode")]
                [Validation(Required=false)]
                public string TagCode { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("tagId")]
                [Validation(Required=false)]
                public long? TagId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("tagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
