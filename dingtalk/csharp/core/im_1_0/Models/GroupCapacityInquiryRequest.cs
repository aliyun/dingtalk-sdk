// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class GroupCapacityInquiryRequest : TeaModel {
        /// <summary>
        /// 有效生命周期
        /// </summary>
        [NameInMap("effectiveDuration")]
        [Validation(Required=false)]
        public string EffectiveDuration { get; set; }

        /// <summary>
        /// 开放的群id
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 当前操作人工号
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, object> Options { get; set; }

        /// <summary>
        /// 目标容量
        /// </summary>
        [NameInMap("targetCapacity")]
        [Validation(Required=false)]
        public int? TargetCapacity { get; set; }

    }

}
