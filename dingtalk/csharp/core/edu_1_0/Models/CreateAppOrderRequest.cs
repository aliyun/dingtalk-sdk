// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateAppOrderRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public int? BizCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("detailList")]
        [Validation(Required=false)]
        public List<CreateAppOrderRequestDetailList> DetailList { get; set; }
        public class CreateAppOrderRequestDetailList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("goodsId")]
            [Validation(Required=false)]
            public string GoodsId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("goodsName")]
            [Validation(Required=false)]
            public string GoodsName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("goodsPrice")]
            [Validation(Required=false)]
            public long? GoodsPrice { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("goodsQuantity")]
            [Validation(Required=false)]
            public int? GoodsQuantity { get; set; }

        }

        [NameInMap("labelAmount")]
        [Validation(Required=false)]
        public long? LabelAmount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("merchantOrderNo")]
        [Validation(Required=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("outerUserId")]
        [Validation(Required=false)]
        public string OuterUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
