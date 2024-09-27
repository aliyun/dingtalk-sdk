// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class UpdateIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>tPr_FB_mT_xxxxxxxxx2hQ05201655306463</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<UpdateIntegratedTaskRequestTasks> Tasks { get; set; }
        public class UpdateIntegratedTaskRequestTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>AGREE</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

    }

}
