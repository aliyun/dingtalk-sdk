// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class QueryTradeOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("articleCode")]
        [Validation(Required=false)]
        public string ArticleCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("articleItemCode")]
        [Validation(Required=false)]
        public string ArticleItemCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("articleItemName")]
        [Validation(Required=false)]
        public string ArticleItemName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("articleName")]
        [Validation(Required=false)]
        public string ArticleName { get; set; }

        [NameInMap("closeTime")]
        [Validation(Required=false)]
        public long? CloseTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fee")]
        [Validation(Required=false)]
        public long? Fee { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("isvCropId")]
        [Validation(Required=false)]
        public string IsvCropId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("outerOrderId")]
        [Validation(Required=false)]
        public string OuterOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("payFee")]
        [Validation(Required=false)]
        public long? PayFee { get; set; }

        [NameInMap("payTime")]
        [Validation(Required=false)]
        public long? PayTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        [NameInMap("refundTime")]
        [Validation(Required=false)]
        public long? RefundTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
