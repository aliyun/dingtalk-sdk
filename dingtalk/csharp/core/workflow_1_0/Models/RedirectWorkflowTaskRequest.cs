// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class RedirectWorkflowTaskRequest : TeaModel {
        /// <summary>
        /// 操作节点名
        /// </summary>
        [NameInMap("actionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        /// <summary>
        /// 文件。
        /// </summary>
        [NameInMap("file")]
        [Validation(Required=false)]
        public RedirectWorkflowTaskRequestFile File { get; set; }
        public class RedirectWorkflowTaskRequestFile : TeaModel {
            /// <summary>
            /// 附件列表。
            /// </summary>
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<RedirectWorkflowTaskRequestFileAttachments> Attachments { get; set; }
            public class RedirectWorkflowTaskRequestFileAttachments : TeaModel {
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
        /// 操作人的用户ID，需要跟任务的当前执行人保持一致，否则无法通过校验
        /// </summary>
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        /// <summary>
        /// 转交备注信息
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// OA审批任务ID
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// OA审批任务被转交对象的用户ID
        /// </summary>
        [NameInMap("toUserId")]
        [Validation(Required=false)]
        public string ToUserId { get; set; }

    }

}
