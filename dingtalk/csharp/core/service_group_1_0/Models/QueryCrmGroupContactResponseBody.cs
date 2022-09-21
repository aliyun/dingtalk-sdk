// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryCrmGroupContactResponseBody : TeaModel {
        /// <summary>
        /// 游标
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 开放会话ID
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 群成员数据列表
        /// </summary>
        [NameInMap("records")]
        [Validation(Required=false)]
        public List<QueryCrmGroupContactResponseBodyRecords> Records { get; set; }
        public class QueryCrmGroupContactResponseBodyRecords : TeaModel {
            /// <summary>
            /// 联系人画像数据
            /// </summary>
            [NameInMap("contactData")]
            [Validation(Required=false)]
            public string ContactData { get; set; }

            /// <summary>
            /// 成员unionId
            /// </summary>
            [NameInMap("memberUnionId")]
            [Validation(Required=false)]
            public string MemberUnionId { get; set; }

            /// <summary>
            /// 成员昵称
            /// </summary>
            [NameInMap("nickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// 成员ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
