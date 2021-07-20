// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetCommentListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetCommentListResponseBodyData> Data { get; set; }
        public class GetCommentListResponseBodyData : TeaModel {
            /// <summary>
            /// 评论者姓名
            /// </summary>
            [NameInMap("commentUserName")]
            [Validation(Required=false)]
            public string CommentUserName { get; set; }

            /// <summary>
            /// 评论内容
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 评论时间
            /// </summary>
            [NameInMap("commentTime")]
            [Validation(Required=false)]
            public float? CommentTime { get; set; }

            /// <summary>
            /// 评论ID
            /// </summary>
            [NameInMap("commentId")]
            [Validation(Required=false)]
            public string CommentId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
