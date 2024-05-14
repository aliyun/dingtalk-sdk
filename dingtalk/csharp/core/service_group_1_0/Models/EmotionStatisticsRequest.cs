// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class EmotionStatisticsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("maxDt")]
        [Validation(Required=false)]
        public string MaxDt { get; set; }

        [NameInMap("maxEmotion")]
        [Validation(Required=false)]
        public double? MaxEmotion { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("minDt")]
        [Validation(Required=false)]
        public string MinDt { get; set; }

        [NameInMap("minEmotion")]
        [Validation(Required=false)]
        public double? MinEmotion { get; set; }

        [NameInMap("openConversationIds")]
        [Validation(Required=false)]
        public string OpenConversationIds { get; set; }

        [NameInMap("openGroupSetId")]
        [Validation(Required=false)]
        public string OpenGroupSetId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

    }

}
