// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class UpdatePointActionAutoAssignRuleRequest : TeaModel {
        /// <summary>
        /// 行为规则列表
        /// </summary>
        [NameInMap("updatePointRuleRequestDTOList")]
        [Validation(Required=false)]
        public List<UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList> UpdatePointRuleRequestDTOList { get; set; }
        public class UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList : TeaModel {
            /// <summary>
            /// 奖励积分1～100
            /// </summary>
            [NameInMap("awardScore")]
            [Validation(Required=false)]
            public long? AwardScore { get; set; }

            /// <summary>
            /// 行为名称 不支持修改 
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// 单日计次上限 1～10
            /// </summary>
            [NameInMap("dayLimitTimes")]
            [Validation(Required=false)]
            public long? DayLimitTimes { get; set; }

            /// <summary>
            /// 生效状态：0无效，1有效
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// 操作人userId
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
