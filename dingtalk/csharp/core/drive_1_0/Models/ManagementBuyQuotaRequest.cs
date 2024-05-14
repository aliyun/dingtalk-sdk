// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdrive_1_0.Models
{
    public class ManagementBuyQuotaRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("order")]
        [Validation(Required=false)]
        public ManagementBuyQuotaRequestOrder Order { get; set; }
        public class ManagementBuyQuotaRequestOrder : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("capacityType")]
            [Validation(Required=false)]
            public string CapacityType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("day")]
            [Validation(Required=false)]
            public int? Day { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("money")]
            [Validation(Required=false)]
            public long? Money { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("orderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
