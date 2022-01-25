// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class CreateTriggerResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("item")]
        [Validation(Required=false)]
        public List<CreateTriggerResponseBodyItem> Item { get; set; }
        public class CreateTriggerResponseBodyItem : TeaModel {
            /// <summary>
            /// 连接平台连接器id
            /// </summary>
            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            /// <summary>
            /// 服务商的连接器Id
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// 服务商的触发事件id
            /// </summary>
            [NameInMap("integratorTriggerId")]
            [Validation(Required=false)]
            public string IntegratorTriggerId { get; set; }

            /// <summary>
            /// 连接平台触发事件id
            /// </summary>
            [NameInMap("dingTriggerId")]
            [Validation(Required=false)]
            public string DingTriggerId { get; set; }

            /// <summary>
            /// 是否成功
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// 错误码
            /// </summary>
            [NameInMap("subErrCode")]
            [Validation(Required=false)]
            public string SubErrCode { get; set; }

            /// <summary>
            /// 错误信息
            /// </summary>
            [NameInMap("subErrMsg")]
            [Validation(Required=false)]
            public string SubErrMsg { get; set; }

        }

    }

}
