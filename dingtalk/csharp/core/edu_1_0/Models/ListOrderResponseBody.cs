// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class ListOrderResponseBody : TeaModel {
        /// <summary>
        /// 列表
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListOrderResponseBodyList> List { get; set; }
        public class ListOrderResponseBodyList : TeaModel {
            [NameInMap("actualAmount")]
            [Validation(Required=false)]
            public long? ActualAmount { get; set; }

            [NameInMap("buyerId")]
            [Validation(Required=false)]
            public string BuyerId { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("orderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            [NameInMap("payTime")]
            [Validation(Required=false)]
            public long? PayTime { get; set; }

            [NameInMap("scene")]
            [Validation(Required=false)]
            public long? Scene { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("tradeNo")]
            [Validation(Required=false)]
            public string TradeNo { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
