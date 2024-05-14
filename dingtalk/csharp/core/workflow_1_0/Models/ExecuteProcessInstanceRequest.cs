// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ExecuteProcessInstanceRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("actionerUserId")]
        [Validation(Required=false)]
        public string ActionerUserId { get; set; }

        [NameInMap("file")]
        [Validation(Required=false)]
        public ExecuteProcessInstanceRequestFile File { get; set; }
        public class ExecuteProcessInstanceRequestFile : TeaModel {
            [NameInMap("attachments")]
            [Validation(Required=false)]
            public List<ExecuteProcessInstanceRequestFileAttachments> Attachments { get; set; }
            public class ExecuteProcessInstanceRequestFileAttachments : TeaModel {
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

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
