// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class ListCommentsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListCommentsResponseBodyResult Result { get; set; }
        public class ListCommentsResponseBodyResult : TeaModel {
            [NameInMap("commentList")]
            [Validation(Required=false)]
            public List<ListCommentsResponseBodyResultCommentList> CommentList { get; set; }
            public class ListCommentsResponseBodyResultCommentList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>comment_id</para>
                /// </summary>
                [NameInMap("commentId")]
                [Validation(Required=false)]
                public string CommentId { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public ListCommentsResponseBodyResultCommentListContent Content { get; set; }
                public class ListCommentsResponseBodyResultCommentListContent : TeaModel {
                    [NameInMap("elements")]
                    [Validation(Required=false)]
                    public List<object> Elements { get; set; }

                }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user_id</para>
                /// </summary>
                [NameInMap("creatorId")]
                [Validation(Required=false)]
                public string CreatorId { get; set; }

                [NameInMap("isGlobal")]
                [Validation(Required=false)]
                public bool? IsGlobal { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>quote</para>
                /// </summary>
                [NameInMap("isSolved")]
                [Validation(Required=false)]
                public bool? IsSolved { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>quote</para>
                /// </summary>
                [NameInMap("quote")]
                [Validation(Required=false)]
                public string Quote { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>topic_id</para>
                /// </summary>
                [NameInMap("topicId")]
                [Validation(Required=false)]
                public string TopicId { get; set; }

                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>next_token</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
