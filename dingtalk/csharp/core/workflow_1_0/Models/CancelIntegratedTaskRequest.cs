// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CancelIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("activityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("activityIds")]
        [Validation(Required=false)]
        public List<string> ActivityIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

    }

}
