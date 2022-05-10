// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class ConsumeUserPointsRequest : TeaModel {
        /// <summary>
        /// 扣减积分数量，1～1000000
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// 幂等外部ID，最大长度32个字符
        /// </summary>
        [NameInMap("outId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        /// <summary>
        /// 备注，最长32个字符
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
