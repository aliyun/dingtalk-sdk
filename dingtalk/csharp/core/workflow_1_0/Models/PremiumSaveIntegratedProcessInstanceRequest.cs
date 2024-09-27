// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedProcessInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;{&quot;mykey&quot;: &quot;myData&quot;}&quot;</para>
        /// </summary>
        [NameInMap("bizData")]
        [Validation(Required=false)]
        public string BizData { get; set; }

        [NameInMap("formComponentValueList")]
        [Validation(Required=false)]
        public List<PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList> FormComponentValueList { get; set; }
        public class PremiumSaveIntegratedProcessInstanceRequestFormComponentValueList : TeaModel {
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
        public List<PremiumSaveIntegratedProcessInstanceRequestNotifiers> Notifiers { get; set; }
        public class PremiumSaveIntegratedProcessInstanceRequestNotifiers : TeaModel {
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
