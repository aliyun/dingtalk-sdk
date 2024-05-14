// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class CreateTriggerRequest : TeaModel {
        [NameInMap("integratorFlag")]
        [Validation(Required=false)]
        public string IntegratorFlag { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("triggerInfo")]
        [Validation(Required=false)]
        public List<CreateTriggerRequestTriggerInfo> TriggerInfo { get; set; }
        public class CreateTriggerRequestTriggerInfo : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("inputSchema")]
            [Validation(Required=false)]
            public string InputSchema { get; set; }

            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("integratorTriggerId")]
            [Validation(Required=false)]
            public string IntegratorTriggerId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
