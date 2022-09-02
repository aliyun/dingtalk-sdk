// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryPointActionAutoAssignRuleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPointActionAutoAssignRuleResponseBodyResult Result { get; set; }
        public class QueryPointActionAutoAssignRuleResponseBodyResult : TeaModel {
            /// <summary>
            /// 行为规则列表
            /// </summary>
            [NameInMap("queryPointRuleResponseDTOS")]
            [Validation(Required=false)]
            public List<QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS> QueryPointRuleResponseDTOS { get; set; }
            public class QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS : TeaModel {
                /// <summary>
                /// 奖励积分
                /// </summary>
                [NameInMap("awardScore")]
                [Validation(Required=false)]
                public long? AwardScore { get; set; }

                /// <summary>
                /// 行为名称
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// 单日计次上限
                /// </summary>
                [NameInMap("dayLimitTimes")]
                [Validation(Required=false)]
                public long? DayLimitTimes { get; set; }

                /// <summary>
                /// 行为描述
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// 生效状态：0无效，1有效
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
