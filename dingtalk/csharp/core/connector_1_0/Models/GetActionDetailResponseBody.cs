// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconnector_1_0.Models
{
    public class GetActionDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dca://ding32fff839a3e0105d.connect.dingtalk.com/ding32fff839a3e0105d/action/G-ACT-101FDEBD3C6E213DB474000P</para>
        /// </summary>
        [NameInMap("connectAssetUri")]
        [Validation(Required=false)]
        public string ConnectAssetUri { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;A registration form&quot;,&quot;description&quot;:&quot;A simple form example.&quot;,&quot;type&quot;:&quot;object&quot;,&quot;required&quot;:[],&quot;properties&quot;:{&quot;password&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;title&quot;:&quot;Password&quot;,&quot;minLength&quot;:3},&quot;telephone&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;title&quot;:&quot;Telephone&quot;,&quot;minLength&quot;:10}}}</para>
        /// </summary>
        [NameInMap("inputSchema")]
        [Validation(Required=false)]
        public string InputSchema { get; set; }

        [NameInMap("integrationConfig")]
        [Validation(Required=false)]
        public GetActionDetailResponseBodyIntegrationConfig IntegrationConfig { get; set; }
        public class GetActionDetailResponseBodyIntegrationConfig : TeaModel {
            [NameInMap("categoryNames")]
            [Validation(Required=false)]
            public List<GetActionDetailResponseBodyIntegrationConfigCategoryNames> CategoryNames { get; set; }
            public class GetActionDetailResponseBodyIntegrationConfigCategoryNames : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>应用</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>表单</para>
            /// </summary>
            [NameInMap("entityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            [NameInMap("props")]
            [Validation(Required=false)]
            public List<GetActionDetailResponseBodyIntegrationConfigProps> Props { get; set; }
            public class GetActionDetailResponseBodyIntegrationConfigProps : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SAMPLE_KEY</para>
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>VALUE</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>XX执行动作</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;A registration form&quot;,&quot;description&quot;:&quot;A simple form example.&quot;,&quot;type&quot;:&quot;object&quot;,&quot;required&quot;:[],&quot;properties&quot;:{&quot;password&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;title&quot;:&quot;Password&quot;,&quot;minLength&quot;:3},&quot;telephone&quot;:{&quot;type&quot;:&quot;string&quot;,&quot;title&quot;:&quot;Telephone&quot;,&quot;minLength&quot;:10}}}</para>
        /// </summary>
        [NameInMap("outputSchema")]
        [Validation(Required=false)]
        public string OutputSchema { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>G-ACT-101FDEBD3C6E213DB474000P</para>
        /// </summary>
        [NameInMap("refId")]
        [Validation(Required=false)]
        public string RefId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding32fff839a3e0105d</para>
        /// </summary>
        [NameInMap("refProviderCorpId")]
        [Validation(Required=false)]
        public string RefProviderCorpId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>action</para>
        /// </summary>
        [NameInMap("refType")]
        [Validation(Required=false)]
        public string RefType { get; set; }

    }

}
