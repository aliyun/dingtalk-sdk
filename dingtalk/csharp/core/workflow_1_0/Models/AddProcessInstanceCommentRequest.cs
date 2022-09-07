// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class AddProcessInstanceCommentRequest : TeaModel {
        /// <summary>
        /// 评论人的userid。
        /// </summary>
        [NameInMap("commentUserId")]
        [Validation(Required=false)]
        public string CommentUserId { get; set; }

        /// <summary>
        /// 文件。
        /// </summary>
        [NameInMap("file")]
        [Validation(Required=false)]
        public AddProcessInstanceCommentRequestFile File { get; set; }
        public class AddProcessInstanceCommentRequestFile : TeaModel {
            /// <summary>
            /// 附件列表。
            /// </summary>
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<AddProcessInstanceCommentRequestFileAttachments> Attachments { get; set; }
            public class AddProcessInstanceCommentRequestFileAttachments : TeaModel {
                /// <summary>
                /// 文件ID。
                /// </summary>
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// 文件名称。
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// 文件大小。
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// 文件类型。
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// 钉盘空间ID。
                /// </summary>
                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

            }

            /// <summary>
            /// 图片URL地址。
            /// </summary>
            [NameInMap("photos")]
            [Validation(Required=false)]
            public List<string> Photos { get; set; }

        }

        /// <summary>
        /// 审批实例ID，可通过调用获取审批实例ID列表接口获取。
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// 评论的内容。
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
