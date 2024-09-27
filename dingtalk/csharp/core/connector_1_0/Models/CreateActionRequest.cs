// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class CreateActionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("actionInfo")]
        [Validation(Required=false)]
        public List<CreateActionRequestActionInfo> ActionInfo { get; set; }
        public class CreateActionRequestActionInfo : TeaModel {
            [NameInMap("apiPath")]
            [Validation(Required=false)]
            public string ApiPath { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dingConnectorId")]
            [Validation(Required=false)]
            public string DingConnectorId { get; set; }

            [NameInMap("inputMappingConfig")]
            [Validation(Required=false)]
            public CreateActionRequestActionInfoInputMappingConfig InputMappingConfig { get; set; }
            public class CreateActionRequestActionInfoInputMappingConfig : TeaModel {
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

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("integratorActionId")]
            [Validation(Required=false)]
            public string IntegratorActionId { get; set; }

            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("outputDataRules")]
            [Validation(Required=false)]
            public List<CreateActionRequestActionInfoOutputDataRules> OutputDataRules { get; set; }
            public class CreateActionRequestActionInfoOutputDataRules : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("expectValue")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>EQ</para>
                /// </summary>
                [NameInMap("operate")]
                [Validation(Required=false)]
                public string Operate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a/b/c</para>
                /// </summary>
                [NameInMap("propertyPath")]
                [Validation(Required=false)]
                public string PropertyPath { get; set; }

            }

            [NameInMap("outputMappingConfig")]
            [Validation(Required=false)]
            public CreateActionRequestActionInfoOutputMappingConfig OutputMappingConfig { get; set; }
            public class CreateActionRequestActionInfoOutputMappingConfig : TeaModel {
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
