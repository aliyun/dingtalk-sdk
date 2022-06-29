// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class PagePointHistoryResponseBody : TeaModel {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 下一个游标值
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 查询所得积分流水集合
        /// </summary>
        [NameInMap("pointRecordList")]
        [Validation(Required=false)]
        public List<PagePointHistoryResponseBodyPointRecordList> PointRecordList { get; set; }
        public class PagePointHistoryResponseBodyPointRecordList : TeaModel {
            /// <summary>
            /// 创建时间（精确到毫秒数）
            /// </summary>
            [NameInMap("createAt")]
            [Validation(Required=false)]
            public long? CreateAt { get; set; }

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
            /// 成员id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 幂等键
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// 总数，如果为-1则不计算总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
