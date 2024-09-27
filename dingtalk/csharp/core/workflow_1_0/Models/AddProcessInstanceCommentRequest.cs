// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class AddProcessInstanceCommentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user123</para>
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
                /// <summary>
                /// <b>Example:</b>
                /// <para>B1oQixxxx</para>
                /// </summary>
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>文件名称。</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public string FileSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>file</para>
                /// </summary>
                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public string SpaceId { get; set; }

            }

            [NameInMap("photos")]
            [Validation(Required=false)]
            public List<string> Photos { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a171de6c-8bxxxx</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>同意。</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

    }

}
