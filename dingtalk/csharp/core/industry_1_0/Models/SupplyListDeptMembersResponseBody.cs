// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class SupplyListDeptMembersResponseBody : TeaModel {
        /// <summary>
        /// 是否还有下一页
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<SupplyListDeptMembersResponseBodyList> List { get; set; }
        public class SupplyListDeptMembersResponseBodyList : TeaModel {
            /// <summary>
            /// 人员状态，已进组织 或 待接收邀请
            /// </summary>
            [NameInMap("dingMemberStatus")]
            [Validation(Required=false)]
            public string DingMemberStatus { get; set; }

            /// <summary>
            /// 是否激活
            /// </summary>
            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            /// <summary>
            /// 名字
            /// </summary>
            [NameInMap("memberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            /// <summary>
            /// 人员在上下游中的工号
            /// </summary>
            [NameInMap("memberWorkNumber")]
            [Validation(Required=false)]
            public string MemberWorkNumber { get; set; }

            /// <summary>
            /// 应用层面的唯一id
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 人员组织内id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
