// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwatt_1_0.Models
{
    public class CreateDeliveryPlanRequest : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public Dictionary<string, object> Content { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1028</para>
        /// </summary>
        [NameInMap("resId")]
        [Validation(Required=false)]
        public string ResId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("userIdList")]
        [Validation(Required=false)]
        public List<string> UserIdList { get; set; }

    }

}
