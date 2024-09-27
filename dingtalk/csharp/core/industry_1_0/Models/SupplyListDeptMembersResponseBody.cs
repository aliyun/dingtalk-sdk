// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyListDeptMembersResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SupplyListDeptMembersResponseBodyList> List { get; set; }
        public class SupplyListDeptMembersResponseBodyList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李白</para>
            /// </summary>
            [NameInMap("memberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>经理</para>
            /// </summary>
            [NameInMap("memberTitle")]
            [Validation(Required=false)]
            public string MemberTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("memberWorkNumber")]
            [Validation(Required=false)]
            public string MemberWorkNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123abc</para>
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123344</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
