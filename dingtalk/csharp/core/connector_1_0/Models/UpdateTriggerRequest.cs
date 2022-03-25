// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class UpdateTriggerRequest : TeaModel {
        [NameInMap("integratorFlag")]
        [Validation(Required=false)]
        public string IntegratorFlag { get; set; }

        [NameInMap("triggerInfo")]
        [Validation(Required=false)]
        public List<UpdateTriggerRequestTriggerInfo> TriggerInfo { get; set; }
        public class UpdateTriggerRequestTriggerInfo : TeaModel {
            /// <summary>
            /// 触发事件描述。
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 连接平台连接器唯一标识。
            /// </summary>
            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            /// <summary>
            /// 连接平台触发事件唯一标识。
            /// </summary>
            [NameInMap("dingTriggerId")]
            [Validation(Required=false)]
            public string DingTriggerId { get; set; }

            /// <summary>
            /// 入参属性描述。
            /// </summary>
            [NameInMap("inputSchema")]
            [Validation(Required=false)]
            public string InputSchema { get; set; }

            /// <summary>
            /// 服务商的连接器唯一标识。
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// 服务商的触发事件唯一标识。
            /// </summary>
            [NameInMap("integratorTriggerId")]
            [Validation(Required=false)]
            public string IntegratorTriggerId { get; set; }

            /// <summary>
            /// 触发事件名称。
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
