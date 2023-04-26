// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class UpdateActionRequest : TeaModel {
        [NameInMap("actionInfo")]
        [Validation(Required=false)]
        public List<UpdateActionRequestActionInfo> ActionInfo { get; set; }
        public class UpdateActionRequestActionInfo : TeaModel {
            [NameInMap("apiPath")]
            [Validation(Required=false)]
            public string ApiPath { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dingActionId")]
            [Validation(Required=false)]
            public string DingActionId { get; set; }

            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            [NameInMap("inputMappingConfig")]
            [Validation(Required=false)]
            public UpdateActionRequestActionInfoInputMappingConfig InputMappingConfig { get; set; }
            public class UpdateActionRequestActionInfoInputMappingConfig : TeaModel {
                [NameInMap("customSchemaMapping")]
                [Validation(Required=false)]
                public string CustomSchemaMapping { get; set; }

                [NameInMap("rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

            }

            [NameInMap("inputSchema")]
            [Validation(Required=false)]
            public string InputSchema { get; set; }

            [NameInMap("integratorActionId")]
            [Validation(Required=false)]
            public string IntegratorActionId { get; set; }

            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outputDataRules")]
            [Validation(Required=false)]
            public List<UpdateActionRequestActionInfoOutputDataRules> OutputDataRules { get; set; }
            public class UpdateActionRequestActionInfoOutputDataRules : TeaModel {
                [NameInMap("expectValue")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                [NameInMap("operate")]
                [Validation(Required=false)]
                public string Operate { get; set; }

                [NameInMap("propertyPath")]
                [Validation(Required=false)]
                public string PropertyPath { get; set; }

            }

            [NameInMap("outputMappingConfig")]
            [Validation(Required=false)]
            public UpdateActionRequestActionInfoOutputMappingConfig OutputMappingConfig { get; set; }
            public class UpdateActionRequestActionInfoOutputMappingConfig : TeaModel {
                [NameInMap("customSchemaMapping")]
                [Validation(Required=false)]
                public string CustomSchemaMapping { get; set; }

                [NameInMap("rules")]
                [Validation(Required=false)]
                public string Rules { get; set; }

            }

            [NameInMap("outputSchema")]
            [Validation(Required=false)]
            public string OutputSchema { get; set; }

        }

        [NameInMap("integratorFlag")]
        [Validation(Required=false)]
        public string IntegratorFlag { get; set; }

    }

}
