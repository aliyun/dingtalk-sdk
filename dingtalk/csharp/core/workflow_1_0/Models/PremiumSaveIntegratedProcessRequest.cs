// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedProcessRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("formComponents")]
        [Validation(Required=false)]
        public List<FormComponent> FormComponents { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("processFeatureConfig")]
        [Validation(Required=false)]
        public PremiumSaveIntegratedProcessRequestProcessFeatureConfig ProcessFeatureConfig { get; set; }
        public class PremiumSaveIntegratedProcessRequestProcessFeatureConfig : TeaModel {
            [NameInMap("features")]
            [Validation(Required=false)]
            public List<PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures> Features { get; set; }
            public class PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeatures : TeaModel {
                [NameInMap("callback")]
                [Validation(Required=false)]
                public PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback Callback { get; set; }
                public class PremiumSaveIntegratedProcessRequestProcessFeatureConfigFeaturesCallback : TeaModel {
                    [NameInMap("apiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    [NameInMap("appUuid")]
                    [Validation(Required=false)]
                    public string AppUuid { get; set; }

                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                [NameInMap("runType")]
                [Validation(Required=false)]
                public string RunType { get; set; }

            }

        }

        [NameInMap("templateConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public PremiumSaveIntegratedProcessRequestTemplateConfig TemplateConfig { get; set; }
        public class PremiumSaveIntegratedProcessRequestTemplateConfig : TeaModel {
            [NameInMap("createInstanceMobileUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string CreateInstanceMobileUrl { get; set; }

            [NameInMap("createInstancePcUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string CreateInstancePcUrl { get; set; }

            [NameInMap("disableSendCard")]
            [Validation(Required=false)]
            public bool? DisableSendCard { get; set; }

            [NameInMap("hidden")]
            [Validation(Required=false)]
            public bool? Hidden { get; set; }

            [NameInMap("templateEditUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string TemplateEditUrl { get; set; }

        }

    }

}
