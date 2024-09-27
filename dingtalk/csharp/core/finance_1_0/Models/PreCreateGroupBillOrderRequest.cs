// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class PreCreateGroupBillOrderRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("billItemList")]
        [Validation(Required=false)]
        public List<PreCreateGroupBillOrderRequestBillItemList> BillItemList { get; set; }
        public class PreCreateGroupBillOrderRequestBillItemList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.12</para>
            /// </summary>
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cshadbikahdksnajhada</para>
            /// </summary>
            [NameInMap("payerUnionId")]
            [Validation(Required=false)]
            public string PayerUnionId { get; set; }

        }

        [NameInMap("extParams")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("headCount")]
        [Validation(Required=false)]
        public long? HeadCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("isAverageAmount")]
        [Validation(Required=false)]
        public int? IsAverageAmount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhqhadsnkj2qweqsw2</para>
        /// </summary>
        [NameInMap("merchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>opemcesdjuwqw2uwnedj==</para>
        /// </summary>
        [NameInMap("openCid")]
        [Validation(Required=false)]
        public string OpenCid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20230918291921929193911</para>
        /// </summary>
        [NameInMap("outBizNo")]
        [Validation(Required=false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding32fff839a3e0105d</para>
        /// </summary>
        [NameInMap("payeeCorpId")]
        [Validation(Required=false)]
        public string PayeeCorpId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECEjwiiwenwnw2q2sdd</para>
        /// </summary>
        [NameInMap("payeeUnionId")]
        [Validation(Required=false)]
        public string PayeeUnionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>饿了么拼单-测试</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.24</para>
        /// </summary>
        [NameInMap("totalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

    }

}
