// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateItemRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("effectType")]
        [Validation(Required=false)]
        public long? EffectType { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("optUser")]
        [Validation(Required=false)]
        public string OptUser { get; set; }

        [NameInMap("periodType")]
        [Validation(Required=false)]
        public long? PeriodType { get; set; }

        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        [NameInMap("scene")]
        [Validation(Required=false)]
        public long? Scene { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

    }

}
