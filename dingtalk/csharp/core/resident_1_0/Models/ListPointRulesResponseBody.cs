// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class ListPointRulesResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pointRuleList")]
        [Validation(Required=false)]
        public List<ListPointRulesResponseBodyPointRuleList> PointRuleList { get; set; }
        public class ListPointRulesResponseBodyPointRuleList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dayLimitTimes")]
            [Validation(Required=false)]
            public int? DayLimitTimes { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public int? OrderId { get; set; }

            [NameInMap("ruleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
