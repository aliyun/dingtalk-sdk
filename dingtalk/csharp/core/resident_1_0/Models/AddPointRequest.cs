// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class AddPointRequest : TeaModel {
        /// <summary>
        /// 增加积分的时间戳毫秒数，如果为空使用系统当前毫秒数
        /// </summary>
        [NameInMap("actionTime")]
        [Validation(Required=false)]
        public long? ActionTime { get; set; }

        /// <summary>
        /// 是否查询全员圈积分
        /// </summary>
        [NameInMap("isCircle")]
        [Validation(Required=false)]
        public bool? IsCircle { get; set; }

        /// <summary>
        /// 规则代码（可空）,如果不为空的话，score值使用ruleCode对应的score增加分数
        /// </summary>
        [NameInMap("ruleCode")]
        [Validation(Required=false)]
        public string RuleCode { get; set; }

        /// <summary>
        /// 规则名字
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// 本次增加积分：正数表示增加/负数表示扣减
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
        /// 加积分的唯一幂等标志
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
