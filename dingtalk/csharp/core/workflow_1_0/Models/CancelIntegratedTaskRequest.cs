// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CancelIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// 待办组ID，需要在调用创建待办接口时，主动设置该值。
        /// </summary>
        [NameInMap("activityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 待办组ID列表，用于批量取消。
        /// </summary>
        [NameInMap("activityIds")]
        [Validation(Required=false)]
        public List<string> ActivityIds { get; set; }

        /// <summary>
        /// OA审批流程实例ID
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
