// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class UpdateTriggerRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("integratorFlag")]
        [Validation(Required=false)]
        public string IntegratorFlag { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("triggerInfo")]
        [Validation(Required=false)]
        public List<UpdateTriggerRequestTriggerInfo> TriggerInfo { get; set; }
        public class UpdateTriggerRequestTriggerInfo : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            [NameInMap("dingTriggerId")]
            [Validation(Required=false)]
            public string DingTriggerId { get; set; }

            [NameInMap("inputSchema")]
            [Validation(Required=false)]
            public string InputSchema { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("integratorTriggerId")]
            [Validation(Required=false)]
            public string IntegratorTriggerId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
