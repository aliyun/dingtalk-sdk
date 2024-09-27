// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class SaveIntegratedInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;{&quot;mykey&quot;: &quot;myData&quot;}&quot;</para>
        /// </summary>
        [NameInMap("bizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        [NameInMap("featureConfig")]
        [Validation(Required=false)]
        public SaveIntegratedInstanceRequestFeatureConfig FeatureConfig { get; set; }
        public class SaveIntegratedInstanceRequestFeatureConfig : TeaModel {
            [NameInMap("features")]
            [Validation(Required=false)]
            public List<SaveIntegratedInstanceRequestFeatureConfigFeatures> Features { get; set; }
            public class SaveIntegratedInstanceRequestFeatureConfigFeatures : TeaModel {
                [NameInMap("callback")]
                [Validation(Required=false)]
                public SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback Callback { get; set; }
                public class SaveIntegratedInstanceRequestFeatureConfigFeaturesCallback : TeaModel {
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

        [NameInMap("formComponentValueList")]
        [Validation(Required=false)]
        public List<SaveIntegratedInstanceRequestFormComponentValueList> FormComponentValueList { get; set; }
        public class SaveIntegratedInstanceRequestFormComponentValueList : TeaModel {
            [NameInMap("bizAlias")]
            [Validation(Required=false)]
            public string BizAlias { get; set; }

            [NameInMap("componentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

            [NameInMap("extValue")]
            [Validation(Required=false)]
            public string ExtValue { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("notifiers")]
        [Validation(Required=false)]
        public List<SaveIntegratedInstanceRequestNotifiers> Notifiers { get; set; }
        public class SaveIntegratedInstanceRequestNotifiers : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>start</para>
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manager001</para>
            /// </summary>
            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("originatorUserId")]
        [Validation(Required=false)]
        public string OriginatorUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.dingtalk.com/">https://www.dingtalk.com/</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
