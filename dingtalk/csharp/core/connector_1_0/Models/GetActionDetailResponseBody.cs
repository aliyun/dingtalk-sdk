// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class GetActionDetailResponseBody : TeaModel {
        [NameInMap("connectAssetUri")]
        [Validation(Required=false)]
        public string ConnectAssetUri { get; set; }

        [NameInMap("inputSchema")]
        [Validation(Required=false)]
        public string InputSchema { get; set; }

        [NameInMap("integrationConfig")]
        [Validation(Required=false)]
        public GetActionDetailResponseBodyIntegrationConfig IntegrationConfig { get; set; }
        public class GetActionDetailResponseBodyIntegrationConfig : TeaModel {
            [NameInMap("categoryNames")]
            [Validation(Required=false)]
            public List<GetActionDetailResponseBodyIntegrationConfigCategoryNames> CategoryNames { get; set; }
            public class GetActionDetailResponseBodyIntegrationConfigCategoryNames : TeaModel {
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("entityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            [NameInMap("props")]
            [Validation(Required=false)]
            public List<GetActionDetailResponseBodyIntegrationConfigProps> Props { get; set; }
            public class GetActionDetailResponseBodyIntegrationConfigProps : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("outputSchema")]
        [Validation(Required=false)]
        public string OutputSchema { get; set; }

        [NameInMap("refId")]
        [Validation(Required=false)]
        public string RefId { get; set; }

        [NameInMap("refProviderCorpId")]
        [Validation(Required=false)]
        public string RefProviderCorpId { get; set; }

        [NameInMap("refType")]
        [Validation(Required=false)]
        public string RefType { get; set; }

    }

}
