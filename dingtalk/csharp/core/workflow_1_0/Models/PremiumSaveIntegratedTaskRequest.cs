// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>act_xxxx</para>
        /// </summary>
        [NameInMap("activityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        [NameInMap("featureConfig")]
        [Validation(Required=false)]
        public PremiumSaveIntegratedTaskRequestFeatureConfig FeatureConfig { get; set; }
        public class PremiumSaveIntegratedTaskRequestFeatureConfig : TeaModel {
            [NameInMap("features")]
            [Validation(Required=false)]
            public List<PremiumSaveIntegratedTaskRequestFeatureConfigFeatures> Features { get; set; }
            public class PremiumSaveIntegratedTaskRequestFeatureConfigFeatures : TeaModel {
                [NameInMap("callback")]
                [Validation(Required=false)]
                public PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback Callback { get; set; }
                public class PremiumSaveIntegratedTaskRequestFeatureConfigFeaturesCallback : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("apiKey")]
                    [Validation(Required=false)]
                    public string ApiKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>abc</para>
                    /// </summary>
                    [NameInMap("appUuid")]
                    [Validation(Required=false)]
                    public string AppUuid { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
                /// </summary>
                [NameInMap("mobileUrl")]
                [Validation(Required=false)]
                public string MobileUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://www.dingtalk.com">www.dingtalk.com</a></para>
                /// </summary>
                [NameInMap("pcUrl")]
                [Validation(Required=false)]
                public string PcUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ORIGIN</para>
                /// </summary>
                [NameInMap("runType")]
                [Validation(Required=false)]
                public string RunType { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tPr_FB_mT_xxxxxxxxx2hQ05201655306463</para>
        /// </summary>
        [NameInMap("processInstanceId")]
        [Validation(Required=false)]
        public string ProcessInstanceId { get; set; }

        [NameInMap("taskConfig")]
        [Validation(Required=false)]
        public PremiumSaveIntegratedTaskRequestTaskConfig TaskConfig { get; set; }
        public class PremiumSaveIntegratedTaskRequestTaskConfig : TeaModel {
            [NameInMap("disableSendCard")]
            [Validation(Required=false)]
            public bool? DisableSendCard { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<PremiumSaveIntegratedTaskRequestTasks> Tasks { get; set; }
        public class PremiumSaveIntegratedTaskRequestTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;id&quot;:&quot;12345&quot;}</para>
            /// </summary>
            [NameInMap("customData")]
            [Validation(Required=false)]
            public string CustomData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1758643200000</para>
            /// </summary>
            [NameInMap("dueTimestamp")]
            [Validation(Required=false)]
            public long? DueTimestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.dingtalk.com">https://www.dingtalk.com</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
