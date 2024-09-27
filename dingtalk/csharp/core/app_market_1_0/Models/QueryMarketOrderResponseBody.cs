// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class QueryMarketOrderResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2092310001312</para>
        /// </summary>
        [NameInMap("bizOrderId")]
        [Validation(Required=false)]
        public long? BizOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding23219001</para>
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10003298001</para>
        /// </summary>
        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("endTimestamp")]
        [Validation(Required=false)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FW_GOODS_12319001</para>
        /// </summary>
        [NameInMap("goodsCode")]
        [Validation(Required=false)]
        public string GoodsCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试商品001</para>
        /// </summary>
        [NameInMap("goodsName")]
        [Validation(Required=false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inAppOrder")]
        [Validation(Required=false)]
        public bool? InAppOrder { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FW_GOODS_31001</para>
        /// </summary>
        [NameInMap("itemCode")]
        [Validation(Required=false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试规格001</para>
        /// </summary>
        [NameInMap("itemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10003299001</para>
        /// </summary>
        [NameInMap("paidTimestamp")]
        [Validation(Required=false)]
        public long? PaidTimestamp { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10003298003</para>
        /// </summary>
        [NameInMap("startTimestamp")]
        [Validation(Required=false)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalActualPayFee")]
        [Validation(Required=false)]
        public long? TotalActualPayFee { get; set; }

    }

}
