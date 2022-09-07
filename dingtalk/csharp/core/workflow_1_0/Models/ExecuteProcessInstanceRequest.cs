// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ExecuteProcessInstanceRequest : TeaModel {
        /// <summary>
        /// 操作人userid，可通过调用获取审批实例详情接口获取。
        /// </summary>
        [NameInMap("actionerUserId")]
        [Validation(Required=false)]
        public string ActionerUserId { get; set; }

        /// <summary>
        /// 文件。
        /// </summary>
        [NameInMap("file")]
        [Validation(Required=false)]
        public ExecuteProcessInstanceRequestFile File { get; set; }
        public class ExecuteProcessInstanceRequestFile : TeaModel {
            /// <summary>
            /// 附件列表。
            /// </summary>
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<ExecuteProcessInstanceRequestFileAttachments> Attachments { get; set; }
            public class ExecuteProcessInstanceRequestFileAttachments : TeaModel {
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
        /// 审批意见，可为空。
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 审批操作，取值。
        /// 
        /// agree：同意
        /// 
        /// refuse：拒绝
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// 任务节点id，可通过调用获取审批实例详情接口获取。
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
