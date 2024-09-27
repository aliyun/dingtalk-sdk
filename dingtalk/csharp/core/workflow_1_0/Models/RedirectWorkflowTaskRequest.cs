// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class RedirectWorkflowTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("actionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        [NameInMap("file")]
        [Validation(Required=false)]
        public RedirectWorkflowTaskRequestFile File { get; set; }
        public class RedirectWorkflowTaskRequestFile : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<RedirectWorkflowTaskRequestFileAttachments> Attachments { get; set; }
            public class RedirectWorkflowTaskRequestFileAttachments : TeaModel {
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
        /// <para>manager001</para>
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>请XX帮忙审批一下</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager001</para>
        /// </summary>
        [NameInMap("toUserId")]
        [Validation(Required=false)]
        public string ToUserId { get; set; }

    }

}
