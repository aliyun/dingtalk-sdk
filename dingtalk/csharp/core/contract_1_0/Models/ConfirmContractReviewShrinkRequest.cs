// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class ConfirmContractReviewShrinkRequest : TeaModel {
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
        public string CustomRulesShrink { get; set; }

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
