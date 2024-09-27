// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetTaskByIdsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>60a2187eb72xxxxxxx</para>
        /// </summary>
        [NameInMap("parentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60a2187eb72xxxxxxx</para>
        /// </summary>
        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
