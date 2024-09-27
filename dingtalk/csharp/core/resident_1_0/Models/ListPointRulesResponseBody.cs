// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class ListPointRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("pointRuleList")]
        [Validation(Required=false)]
        public List<ListPointRulesResponseBodyPointRuleList> PointRuleList { get; set; }
        public class ListPointRulesResponseBodyPointRuleList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("dayLimitTimes")]
            [Validation(Required=false)]
            public int? DayLimitTimes { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("groupId")]
            [Validation(Required=false)]
            public int? GroupId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>排序Id</para>
            /// </summary>
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public int? OrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rule_1</para>
            /// </summary>
            [NameInMap("ruleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>发动态</para>
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public int? Score { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

    }

}
