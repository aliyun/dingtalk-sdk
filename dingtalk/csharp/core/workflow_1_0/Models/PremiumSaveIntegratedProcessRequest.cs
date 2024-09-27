// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedProcessRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>用于员工差旅费用报销使用</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("formComponents")]
        [Validation(Required=false)]
        public List<FormComponent> FormComponents { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>出差报销审批</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>proc-abc</para>
        /// </summary>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("templateConfig")]
        [Validation(Required=false)]
        [Obsolete]
        public PremiumSaveIntegratedProcessRequestTemplateConfig TemplateConfig { get; set; }
        public class PremiumSaveIntegratedProcessRequestTemplateConfig : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://open.dingtalk.com/">https://open.dingtalk.com/</a></para>
            /// </summary>
            [NameInMap("createInstanceMobileUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string CreateInstanceMobileUrl { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://open.dingtalk.com/">https://open.dingtalk.com/</a></para>
            /// </summary>
            [NameInMap("createInstancePcUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string CreateInstancePcUrl { get; set; }

            /// <summary>
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("disableSendCard")]
            [Validation(Required=false)]
            public bool? DisableSendCard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hidden")]
            [Validation(Required=false)]
            public bool? Hidden { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://open.dingtalk.com/">https://open.dingtalk.com/</a></para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("templateEditUrl")]
            [Validation(Required=false)]
            [Obsolete]
            public string TemplateEditUrl { get; set; }

        }

    }

}
