// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class UpdateOrganizationTaskExecutorRequest : TeaModel {
        [NameInMap("disableActivity")]
        [Validation(Required=false)]
        public bool? DisableActivity { get; set; }

        [NameInMap("disableNotification")]
        [Validation(Required=false)]
        public bool? DisableNotification { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("executorId")]
        [Validation(Required=false)]
        public string ExecutorId { get; set; }

    }

}
