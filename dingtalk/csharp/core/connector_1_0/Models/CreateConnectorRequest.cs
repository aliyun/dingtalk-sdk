// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class CreateConnectorRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("connectorInfo")]
        [Validation(Required=false)]
        public List<CreateConnectorRequestConnectorInfo> ConnectorInfo { get; set; }
        public class CreateConnectorRequestConnectorInfo : TeaModel {
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

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("domainEnv")]
            [Validation(Required=false)]
            public bool? DomainEnv { get; set; }

            [NameInMap("iconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("integratorFlag")]
        [Validation(Required=false)]
        public string IntegratorFlag { get; set; }

    }

}
