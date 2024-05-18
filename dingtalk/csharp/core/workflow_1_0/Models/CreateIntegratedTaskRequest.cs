// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class CreateIntegratedTaskRequest : TeaModel {
        [NameInMap("activityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("featureConfig")]
        [Validation(Required=false)]
        public CreateIntegratedTaskRequestFeatureConfig FeatureConfig { get; set; }
        public class CreateIntegratedTaskRequestFeatureConfig : TeaModel {
            [NameInMap("features")]
            [Validation(Required=false)]
            public List<CreateIntegratedTaskRequestFeatureConfigFeatures> Features { get; set; }
            public class CreateIntegratedTaskRequestFeatureConfigFeatures : TeaModel {
                [NameInMap("callback")]
                [Validation(Required=false)]
                public CreateIntegratedTaskRequestFeatureConfigFeaturesCallback Callback { get; set; }
                public class CreateIntegratedTaskRequestFeatureConfigFeaturesCallback : TeaModel {
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

                [NameInMap("config")]
                [Validation(Required=false)]
                public string Config { get; set; }

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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<CreateIntegratedTaskRequestTasks> Tasks { get; set; }
        public class CreateIntegratedTaskRequestTasks : TeaModel {
            [NameInMap("customData")]
            [Validation(Required=false)]
            public string CustomData { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
