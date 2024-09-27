// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class ExecuteProcessInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>133743186427339452</para>
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
        /// <b>Example:</b>
        /// <para>同意。</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agree</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public string Result { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>67583405630</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
