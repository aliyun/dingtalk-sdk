// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class ListPointRulesResponseBody : TeaModel {
        /// <summary>
        /// 查询所得积分规则集合
        /// </summary>
        [NameInMap("pointRuleList")]
        [Validation(Required=false)]
        public List<ListPointRulesResponseBodyPointRuleList> PointRuleList { get; set; }
        public class ListPointRulesResponseBodyPointRuleList : TeaModel {
            /// <summary>
            /// 单日计次上限，0表示无上限
            /// </summary>
            [NameInMap("dayLimitTimes")]
            [Validation(Required=false)]
            public int? DayLimitTimes { get; set; }

            /// <summary>
            /// 扩展字段
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// 分组ID, 默认写入为0
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// 排序ID
            /// </summary>
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public int? OrderId { get; set; }

            /// <summary>
            /// 对应的行为代码（可空）
            /// </summary>
            [NameInMap("ruleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            /// <summary>
            /// 对应的行为名字
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// 增加或减少的分数（增加为正数，减少为负数）
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// 生效状态 0：不生效，1：生效
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
