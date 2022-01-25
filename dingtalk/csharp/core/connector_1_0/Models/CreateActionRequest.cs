// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class CreateActionRequest : TeaModel {
        [NameInMap("actionInfo")]
        [Validation(Required=false)]
        public List<CreateActionRequestActionInfo> ActionInfo { get; set; }
        public class CreateActionRequestActionInfo : TeaModel {
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
            /// 服务商的执行事件Id
            /// </summary>
            [NameInMap("integratorActionId")]
            [Validation(Required=false)]
            public string IntegratorActionId { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// api请求url path，结合Connector上的apiDomain使用
            /// </summary>
            [NameInMap("apiPath")]
            [Validation(Required=false)]
            public string ApiPath { get; set; }

            /// <summary>
            /// 入参schema
            /// </summary>
            [NameInMap("inputSchema")]
            [Validation(Required=false)]
            public string InputSchema { get; set; }

            /// <summary>
            /// 出参schema
            /// </summary>
            [NameInMap("outputSchema")]
            [Validation(Required=false)]
            public string OutputSchema { get; set; }

            /// <summary>
            /// action维度的api请求url
            /// </summary>
            [NameInMap("apiUrl")]
            [Validation(Required=false)]
            public string ApiUrl { get; set; }

            /// <summary>
            /// action维度的apiSecret
            /// </summary>
            [NameInMap("apiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

        }

    }

}
