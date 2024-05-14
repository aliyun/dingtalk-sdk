// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class AddProcessInstanceCommentRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("commentUserId")]
        [Validation(Required=false)]
        public string CommentUserId { get; set; }

        [NameInMap("file")]
        [Validation(Required=false)]
        public AddProcessInstanceCommentRequestFile File { get; set; }
        public class AddProcessInstanceCommentRequestFile : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<AddProcessInstanceCommentRequestFileAttachments> Attachments { get; set; }
            public class AddProcessInstanceCommentRequestFileAttachments : TeaModel {
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

            }

            [NameInMap("photos")]
            [Validation(Required=false)]
            public List<string> Photos { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
