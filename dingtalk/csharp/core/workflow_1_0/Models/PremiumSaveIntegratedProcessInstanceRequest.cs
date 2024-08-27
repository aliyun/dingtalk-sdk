// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PremiumSaveIntegratedProcessInstanceRequest : TeaModel {
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
            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("originatorUserId")]
        [Validation(Required=false)]
        public string OriginatorUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
