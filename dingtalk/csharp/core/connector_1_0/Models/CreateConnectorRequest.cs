// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class CreateConnectorRequest : TeaModel {
        [NameInMap("connectorInfo")]
        [Validation(Required=false)]
        public List<CreateConnectorRequestConnectorInfo> ConnectorInfo { get; set; }
        public class CreateConnectorRequestConnectorInfo : TeaModel {
            /// <summary>
            /// 连接器中执行动作的接口路径域名。
            /// </summary>
            [NameInMap("apiDomain")]
            [Validation(Required=false)]
            public string ApiDomain { get; set; }

            /// <summary>
            /// 连接器中执行动作接口的加密签名。
            /// </summary>
            [NameInMap("apiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            [NameInMap("appId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// 将apiSecret设置为模板变量。
            /// </summary>
            [NameInMap("authValueEnv")]
            [Validation(Required=false)]
            public bool? AuthValueEnv { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 将执行动作域名设为环境变量。
            /// </summary>
            [NameInMap("domainEnv")]
            [Validation(Required=false)]
            public bool? DomainEnv { get; set; }

            [NameInMap("iconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }

            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("integratorFlag")]
        [Validation(Required=false)]
        public string IntegratorFlag { get; set; }

    }

}
