// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class GetActionDetailResponseBody : TeaModel {
        /// <summary>
        /// 连接资产标识
        /// </summary>
        [NameInMap("connectAssetUri")]
        [Validation(Required=false)]
        public string ConnectAssetUri { get; set; }

        /// <summary>
        /// 调用时以JsonSchema描述的入参格式
        /// </summary>
        [NameInMap("inputSchema")]
        [Validation(Required=false)]
        public string InputSchema { get; set; }

        /// <summary>
        /// 执行动作集成配置信息
        /// </summary>
        [NameInMap("integrationConfig")]
        [Validation(Required=false)]
        public GetActionDetailResponseBodyIntegrationConfig IntegrationConfig { get; set; }
        public class GetActionDetailResponseBodyIntegrationConfig : TeaModel {
            /// <summary>
            /// 类目配置
            /// </summary>
            [NameInMap("categoryNames")]
            [Validation(Required=false)]
            public List<GetActionDetailResponseBodyIntegrationConfigCategoryNames> CategoryNames { get; set; }
            public class GetActionDetailResponseBodyIntegrationConfigCategoryNames : TeaModel {
                /// <summary>
                /// 类目名称
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 集成对象的名称
            /// </summary>
            [NameInMap("entityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            /// <summary>
            /// 其它额外属性
            /// </summary>
            [NameInMap("props")]
            [Validation(Required=false)]
            public List<GetActionDetailResponseBodyIntegrationConfigProps> Props { get; set; }
            public class GetActionDetailResponseBodyIntegrationConfigProps : TeaModel {
                /// <summary>
                /// 配置的KEY值
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 配置的属性值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// 执行动作的名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 调用时以JsonSchema描述的出参格式
        /// </summary>
        [NameInMap("outputSchema")]
        [Validation(Required=false)]
        public string OutputSchema { get; set; }

        /// <summary>
        /// 执行动作的ID
        /// </summary>
        [NameInMap("refId")]
        [Validation(Required=false)]
        public string RefId { get; set; }

        /// <summary>
        /// 执行动作提供组织
        /// </summary>
        [NameInMap("refProviderCorpId")]
        [Validation(Required=false)]
        public string RefProviderCorpId { get; set; }

        /// <summary>
        /// 连接资产类型
        /// </summary>
        [NameInMap("refType")]
        [Validation(Required=false)]
        public string RefType { get; set; }

    }

}
