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
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("iconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }

            [NameInMap("appId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            /// <summary>
            /// 连接器下action api请求url域名，当baseVariables中无apiDomain，该项必填
            /// </summary>
            [NameInMap("apiDomain")]
            [Validation(Required=false)]
            public string ApiDomain { get; set; }

            /// <summary>
            /// 连接器下action api请求时使用http加密签名，当baseVariables无apiSecret，该项必填
            /// </summary>
            [NameInMap("apiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            /// <summary>
            /// 变量列表。目前支持将apiDomain、apiSecret声明为基础变量。若声明为变量，则对应属性可不传值
            /// </summary>
            [NameInMap("baseVariables")]
            [Validation(Required=false)]
            public List<string> BaseVariables { get; set; }

        }

    }

}
