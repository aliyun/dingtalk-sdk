// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class UpdateKROfWeightRequest : TeaModel {
        /// <summary>
        /// 权重比。
        /// </summary>
        [NameInMap("weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

        /// <summary>
        /// 当前 KR ID。
        /// </summary>
        [NameInMap("krId")]
        [Validation(Required=false)]
        public string KrId { get; set; }

        /// <summary>
        /// 当前用户的userId。
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
