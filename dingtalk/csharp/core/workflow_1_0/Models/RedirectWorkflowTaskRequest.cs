// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class RedirectWorkflowTaskRequest : TeaModel {
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
        [NameInMap("operateUserId")]
        [Validation(Required=false)]
        public string OperateUserId { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("toUserId")]
        [Validation(Required=false)]
        public string ToUserId { get; set; }

    }

}
