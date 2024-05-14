// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class AddCommentRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("commentContent")]
        [Validation(Required=false)]
        public string CommentContent { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("commentType")]
        [Validation(Required=false)]
        public string CommentType { get; set; }

        [NameInMap("option")]
        [Validation(Required=false)]
        public AddCommentRequestOption Option { get; set; }
        public class AddCommentRequestOption : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("extra")]
            [Validation(Required=false)]
            public Dictionary<string, string> Extra { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
