// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateTaskTaskflowstatusRequest : TeaModel {
        /// <summary>
        /// 任务状态ID。
        /// </summary>
        [NameInMap("taskflowStatusId")]
        [Validation(Required=false)]
        public string TaskflowStatusId { get; set; }

        /// <summary>
        /// 任务流转说明。
        /// </summary>
        [NameInMap("tfsUpdateNote")]
        [Validation(Required=false)]
        public string TfsUpdateNote { get; set; }

    }

}
