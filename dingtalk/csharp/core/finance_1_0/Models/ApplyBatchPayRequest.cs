// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ApplyBatchPayRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021070712440326300185114</para>
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20210909153300000002734753314700</para>
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>map</para>
        /// </summary>
        [NameInMap("passBackParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> PassBackParams { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PC</para>
        /// </summary>
        [NameInMap("payTerminal")]
        [Validation(Required=false)]
        public string PayTerminal { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xx">http://xx</a></para>
        /// </summary>
        [NameInMap("returnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8754214873</para>
        /// </summary>
        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.00</para>
        /// </summary>
        [NameInMap("transAmount")]
        [Validation(Required=false)]
        public string TransAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>yyyy-MM-dd HH:mm:ss</para>
        /// </summary>
        [NameInMap("transExpireTime")]
        [Validation(Required=false)]
        public string TransExpireTime { get; set; }

    }

}
