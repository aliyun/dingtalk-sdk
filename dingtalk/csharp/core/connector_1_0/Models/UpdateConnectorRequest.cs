// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class UpdateConnectorRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("connectorInfo")]
        [Validation(Required=false)]
        public List<UpdateConnectorRequestConnectorInfo> ConnectorInfo { get; set; }
        public class UpdateConnectorRequestConnectorInfo : TeaModel {
            [NameInMap("apiDomain")]
            [Validation(Required=false)]
            public string ApiDomain { get; set; }

            [NameInMap("apiSecret")]
            [Validation(Required=false)]
            public string ApiSecret { get; set; }

            [NameInMap("appId")]
            [Validation(Required=false)]
            public long? AppId { get; set; }

            [NameInMap("authValueEnv")]
            [Validation(Required=false)]
            public bool? AuthValueEnv { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            [NameInMap("domainEnv")]
            [Validation(Required=false)]
            public bool? DomainEnv { get; set; }

            [NameInMap("iconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("integratorFlag")]
        [Validation(Required=false)]
        public string IntegratorFlag { get; set; }

    }

}
