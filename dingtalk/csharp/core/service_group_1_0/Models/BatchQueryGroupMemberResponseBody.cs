// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class BatchQueryGroupMemberResponseBody : TeaModel {
        /// <summary>
        /// 是否还存在数据
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一次游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 会话ID
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 成员数据列表
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<BatchQueryGroupMemberResponseBodyRecords> Records { get; set; }
        public class BatchQueryGroupMemberResponseBodyRecords : TeaModel {
            /// <summary>
            /// 是否内部员工
            /// </summary>
            [NameInMap("innerStaff")]
            [Validation(Required=false)]
            public bool? InnerStaff { get; set; }

            /// <summary>
            /// 群成员昵称
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

            /// <summary>
            /// 群成员uinionId
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            /// <summary>
            /// 员工ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
