// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateAppOrderRequest : TeaModel {
        /// <summary>
        /// 实际金额，单位分。
        /// </summary>
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        /// <summary>
        /// 支付宝应用id。
        /// </summary>
        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        /// <summary>
        /// 业务编码。
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public int? BizCode { get; set; }

        /// <summary>
        /// 订单明细列表。
        /// </summary>
        [NameInMap("detailList")]
        [Validation(Required=false)]
        public List<CreateAppOrderRequestDetailList> DetailList { get; set; }
        public class CreateAppOrderRequestDetailList : TeaModel {
            /// <summary>
            /// 商品id。
            /// </summary>
            [NameInMap("goodsId")]
            [Validation(Required=false)]
            public string GoodsId { get; set; }

            /// <summary>
            /// 商品名称。
            /// </summary>
            [NameInMap("goodsName")]
            [Validation(Required=false)]
            public string GoodsName { get; set; }

            /// <summary>
            /// 商品价格，单位分。
            /// </summary>
            [NameInMap("goodsPrice")]
            [Validation(Required=false)]
            public long? GoodsPrice { get; set; }

            /// <summary>
            /// 商品数量。
            /// </summary>
            [NameInMap("goodsQuantity")]
            [Validation(Required=false)]
            public int? GoodsQuantity { get; set; }

        }

        /// <summary>
        /// 标签金额，单位分。
        /// </summary>
        [NameInMap("labelAmount")]
        [Validation(Required=false)]
        public long? LabelAmount { get; set; }

        /// <summary>
        /// 商户id。
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户订单号。
        /// </summary>
        [NameInMap("merchantOrderNo")]
        [Validation(Required=false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用户唯一id。
        /// </summary>
        [NameInMap("outerUserId")]
        [Validation(Required=false)]
        public string OuterUserId { get; set; }

        /// <summary>
        /// 签名。
        /// </summary>
        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// 订单标题。
        /// </summary>
        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// 时间戳。
        /// </summary>
        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
