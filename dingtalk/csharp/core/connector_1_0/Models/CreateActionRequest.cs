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
            /// api请求url path，结合Connector上的apiDomain使用
            /// </summary>
            [NameInMap("apiPath")]
            [Validation(Required=false)]
            public string ApiPath { get; set; }

            /// <summary>
            /// 描述
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// 连接平台连接器id
            /// </summary>
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
            };

            /// <summary>
            /// 入参schema
            /// </summary>
            [NameInMap("inputSchema")]
            [Validation(Required=false)]
            public string InputSchema { get; set; }

            /// <summary>
            /// 服务商的执行事件Id
            /// </summary>
            [NameInMap("integratorActionId")]
            [Validation(Required=false)]
            public string IntegratorActionId { get; set; }

            /// <summary>
            /// 服务商的连接器Id
            /// </summary>
            [NameInMap("integratorConnectorId")]
            [Validation(Required=false)]
            public string IntegratorConnectorId { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 执行动作接口成功调用规则。
            /// </summary>
            [NameInMap("outputDataRules")]
            [Validation(Required=false)]
            public List<CreateActionRequestActionInfoOutputDataRules> OutputDataRules { get; set; }
            public class CreateActionRequestActionInfoOutputDataRules : TeaModel {
                /// <summary>
                /// 规则的预期值。
                /// </summary>
                [NameInMap("expectValue")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                /// <summary>
                /// 操作类型。
                /// </summary>
                [NameInMap("operate")]
                [Validation(Required=false)]
                public string Operate { get; set; }

                /// <summary>
                /// 规则的属性路径。
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
            };

            /// <summary>
            /// 出参schema
            /// </summary>
            [NameInMap("outputSchema")]
            [Validation(Required=false)]
            public string OutputSchema { get; set; }

        }

        [NameInMap("integratorFlag")]
        [Validation(Required=false)]
        public string IntegratorFlag { get; set; }

    }

}
