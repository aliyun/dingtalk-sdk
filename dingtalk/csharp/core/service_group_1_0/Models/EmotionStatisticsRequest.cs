// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class EmotionStatisticsRequest : TeaModel {
        /// <summary>
        /// 截止日期
        /// </summary>
        [NameInMap("maxDt")]
        [Validation(Required=false)]
        public string MaxDt { get; set; }

        /// <summary>
        /// 最大情绪值
        /// </summary>
        [NameInMap("maxEmotion")]
        [Validation(Required=false)]
        public double? MaxEmotion { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        [NameInMap("minDt")]
        [Validation(Required=false)]
        public string MinDt { get; set; }

        /// <summary>
        /// 最小情绪值
        /// </summary>
        [NameInMap("minEmotion")]
        [Validation(Required=false)]
        public double? MinEmotion { get; set; }

        /// <summary>
        /// 开放群ID列表（多个以逗号拼接）
        /// </summary>
        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public string OpenConversationIds { get; set; }

        /// <summary>
        /// 开放群分组ID
        /// </summary>
        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
