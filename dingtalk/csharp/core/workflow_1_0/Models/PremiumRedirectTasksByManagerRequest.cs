// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumRedirectTasksByManagerRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("handoverUserId")]
        [Validation(Required=false)]
        public string HandoverUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("managerUserId")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("taskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("transfereeUserId")]
        [Validation(Required=false)]
        public string TransfereeUserId { get; set; }

    }

}
