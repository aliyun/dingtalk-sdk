// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncInvoiceRequest : TeaModel {
        [NameInMap("address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx银行</para>
        /// </summary>
        [NameInMap("bankName")]
        [Validation(Required=false)]
        public string BankName { get; set; }

        [NameInMap("bankNo")]
        [Validation(Required=false)]
        public string BankNo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ding89233847892ndkas</para>
        /// </summary>
        [NameInMap("channelCorpId")]
        [Validation(Required=false)]
        public string ChannelCorpId { get; set; }

        [NameInMap("deleteFlag")]
        [Validation(Required=false)]
        public bool? DeleteFlag { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-21 11:11:11</para>
        /// </summary>
        [NameInMap("gmtAction")]
        [Validation(Required=false)]
        public string GmtAction { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("invoiceId")]
        [Validation(Required=false)]
        public string InvoiceId { get; set; }

        [NameInMap("projectIds")]
        [Validation(Required=false)]
        public List<string> ProjectIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public int? Scope { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        [NameInMap("tel")]
        [Validation(Required=false)]
        public string Tel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("thirdPartId")]
        [Validation(Required=false)]
        public string ThirdPartId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>默认发票抬头</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("unitType")]
        [Validation(Required=false)]
        public int? UnitType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20881001829000</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
