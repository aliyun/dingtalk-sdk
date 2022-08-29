// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class SaveProcessRequest : TeaModel {
        /// <summary>
        /// 表单模板描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 表单控件列表
        /// </summary>
        [NameInMap("formComponents")]
        [Validation(Required=false)]
        public List<FormComponent> FormComponents { get; set; }

        /// <summary>
        /// 表单模板名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 模板code
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 流程中心集成配置
        /// </summary>
        [NameInMap("processFeatureConfig")]
        [Validation(Required=false)]
        public SaveProcessRequestProcessFeatureConfig ProcessFeatureConfig { get; set; }
        public class SaveProcessRequestProcessFeatureConfig : TeaModel {
            [NameInMap("features")]
            [Validation(Required=false)]
            public List<SaveProcessRequestProcessFeatureConfigFeatures> Features { get; set; }
            public class SaveProcessRequestProcessFeatureConfigFeatures : TeaModel {
                public SaveProcessRequestProcessFeatureConfigFeaturesCallback Callback { get; set; }
                public class SaveProcessRequestProcessFeatureConfigFeaturesCallback : TeaModel {
                    /// <summary>
                    /// 网关接口标识
                    /// </summary>
                    [NameInMap("apiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// 网关接口对应应用的uuid
                    /// </summary>
                    [NameInMap("appUuid")]
                    [Validation(Required=false)]
                    public string AppUuid { get; set; }

                    /// <summary>
                    /// 网关接口版本
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }
                public string MobileUrl { get; set; }
                public string Name { get; set; }
                public string PcUrl { get; set; }
                public string RunType { get; set; }
            }
        };

    }

}
