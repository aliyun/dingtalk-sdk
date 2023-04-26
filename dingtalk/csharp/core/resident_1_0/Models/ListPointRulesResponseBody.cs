// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class ListPointRulesResponseBody : TeaModel {
        [NameInMap("pointRuleList")]
        [Validation(Required=false)]
        public List<ListPointRulesResponseBodyPointRuleList> PointRuleList { get; set; }
        public class ListPointRulesResponseBodyPointRuleList : TeaModel {
            [NameInMap("dayLimitTimes")]
            [Validation(Required=false)]
            public int? DayLimitTimes { get; set; }

            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            [NameInMap("groupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            [NameInMap("orderId")]
            [Validation(Required=false)]
            public int? OrderId { get; set; }

            [NameInMap("ruleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
