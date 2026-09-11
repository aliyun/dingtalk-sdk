// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ConfirmContractReviewRequest : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("checklist_id")]
        [Validation(Required=false)]
        public string ChecklistId { get; set; }

        [NameInMap("contract_type")]
        [Validation(Required=false)]
        public string ContractType { get; set; }

        [NameInMap("custom_rules")]
        [Validation(Required=false)]
        public List<ConfirmContractReviewRequestCustomRules> CustomRules { get; set; }
        public class ConfirmContractReviewRequestCustomRules : TeaModel {
            [NameInMap("contract_type")]
            [Validation(Required=false)]
            public string ContractType { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ConfirmContractReviewRequestCustomRulesItems> Items { get; set; }
            public class ConfirmContractReviewRequestCustomRulesItems : TeaModel {
                [NameInMap("criteria")]
                [Validation(Required=false)]
                public string Criteria { get; set; }

                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("severity")]
                [Validation(Required=false)]
                public string Severity { get; set; }

            }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("risk_level")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("standpoint")]
            [Validation(Required=false)]
            public string Standpoint { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("review_id")]
        [Validation(Required=false)]
        public string ReviewId { get; set; }

        [NameInMap("scale")]
        [Validation(Required=false)]
        public string Scale { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("standpoint")]
        [Validation(Required=false)]
        public string Standpoint { get; set; }

    }

}
