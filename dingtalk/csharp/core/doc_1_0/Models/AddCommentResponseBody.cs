// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class AddCommentResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddCommentResponseBodyResult Result { get; set; }
        public class AddCommentResponseBodyResult : TeaModel {
            [NameInMap("commentId")]
            [Validation(Required=false)]
            public string CommentId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
