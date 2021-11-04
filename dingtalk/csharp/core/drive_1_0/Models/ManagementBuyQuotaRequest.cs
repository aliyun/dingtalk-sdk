// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class ManagementBuyQuotaRequest : TeaModel {
        /// <summary>
        /// 订单
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public ManagementBuyQuotaRequestOrder Order { get; set; }
        public class ManagementBuyQuotaRequestOrder : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }
            [NameInMap("capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }
            [NameInMap("capacityType")]
            [Validation(Required=false)]
            public string CapacityType { get; set; }
            [NameInMap("day")]
            [Validation(Required=false)]
            public int? Day { get; set; }
            [NameInMap("money")]
            [Validation(Required=false)]
            public long? Money { get; set; }
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }
        };

        /// <summary>
        /// token
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
