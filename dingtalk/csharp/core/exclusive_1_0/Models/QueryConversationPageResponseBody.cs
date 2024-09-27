// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class QueryConversationPageResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryConversationPageResponseBodyResult Result { get; set; }
        public class QueryConversationPageResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<QueryConversationPageResponseBodyResultData> Data { get; set; }
            public class QueryConversationPageResponseBodyResultData : TeaModel {
                [NameInMap("categoryId")]
                [Validation(Required=false)]
                public long? CategoryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>未分组</para>
                /// </summary>
                [NameInMap("categoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>S24A01123</para>
                /// </summary>
                [NameInMap("groupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                [NameInMap("groupMembersCnt")]
                [Validation(Required=false)]
                public int? GroupMembersCnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>群聊</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ownername</para>
                /// </summary>
                [NameInMap("groupOwnerName")]
                [Validation(Required=false)]
                public string GroupOwnerName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>useridxxx</para>
                /// </summary>
                [NameInMap("groupOwnerUserId")]
                [Validation(Required=false)]
                public string GroupOwnerUserId { get; set; }

                [NameInMap("isKpConversation")]
                [Validation(Required=false)]
                public bool? IsKpConversation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("manageSign")]
                [Validation(Required=false)]
                public int? ManageSign { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cid123xxxxxx</para>
                /// </summary>
                [NameInMap("openConversationId")]
                [Validation(Required=false)]
                public string OpenConversationId { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>999</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
