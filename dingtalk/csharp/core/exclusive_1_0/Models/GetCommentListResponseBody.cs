// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetCommentListResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetCommentListResponseBodyData> Data { get; set; }
        public class GetCommentListResponseBodyData : TeaModel {
            [NameInMap("commentId")]
            [Validation(Required=false)]
            public string CommentId { get; set; }

            [NameInMap("commentTime")]
            [Validation(Required=false)]
            public float? CommentTime { get; set; }

            [NameInMap("commentUserName")]
            [Validation(Required=false)]
            public string CommentUserName { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
