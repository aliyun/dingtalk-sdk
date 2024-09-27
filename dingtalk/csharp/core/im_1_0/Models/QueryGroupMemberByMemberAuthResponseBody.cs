// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryGroupMemberByMemberAuthResponseBody : TeaModel {
        [NameInMap("groupMemberList")]
        [Validation(Required=false)]
        public List<QueryGroupMemberByMemberAuthResponseBodyGroupMemberList> GroupMemberList { get; set; }
        public class QueryGroupMemberByMemberAuthResponseBodyGroupMemberList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("groupNickName")]
            [Validation(Required=false)]
            public string GroupNickName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>张某某</para>
            /// </summary>
            [NameInMap("orgName")]
            [Validation(Required=false)]
            public string OrgName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://xxx">https://xxx</a></para>
            /// </summary>
            [NameInMap("profilePhotoUrl")]
            [Validation(Required=false)]
            public string ProfilePhotoUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
