// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskTaskflowstatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>60a2187eb72xxxxxxx</para>
        /// </summary>
        [NameInMap("taskflowStatusId")]
        [Validation(Required=false)]
        public string TaskflowStatusId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>说明。</para>
        /// </summary>
        [NameInMap("taskflowStatusUpdateNote")]
        [Validation(Required=false)]
        public string TaskflowStatusUpdateNote { get; set; }

    }

}
