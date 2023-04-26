// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateAppOrderRequest : TeaModel {
        [NameInMap("actualAmount")]
        [Validation(Required=false)]
        public long? ActualAmount { get; set; }

        [NameInMap("alipayAppId")]
        [Validation(Required=false)]
        public string AlipayAppId { get; set; }

        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public int? BizCode { get; set; }

        [NameInMap("detailList")]
        [Validation(Required=false)]
        public List<CreateAppOrderRequestDetailList> DetailList { get; set; }
        public class CreateAppOrderRequestDetailList : TeaModel {
            [NameInMap("goodsId")]
            [Validation(Required=false)]
            public string GoodsId { get; set; }

            [NameInMap("goodsName")]
            [Validation(Required=false)]
            public string GoodsName { get; set; }

            [NameInMap("goodsPrice")]
            [Validation(Required=false)]
            public long? GoodsPrice { get; set; }

            [NameInMap("goodsQuantity")]
            [Validation(Required=false)]
            public int? GoodsQuantity { get; set; }

        }

        [NameInMap("labelAmount")]
        [Validation(Required=false)]
        public long? LabelAmount { get; set; }

        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("merchantOrderNo")]
        [Validation(Required=false)]
        public string MerchantOrderNo { get; set; }

        [NameInMap("outerUserId")]
        [Validation(Required=false)]
        public string OuterUserId { get; set; }

        [NameInMap("signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
