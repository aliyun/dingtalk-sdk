// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class UpdateFinanceEnterpriseAccountRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ACC_XXXXXX</para>
        /// </summary>
        [NameInMap("accountCode")]
        [Validation(Required=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>钉钉科技</para>
        /// </summary>
        [NameInMap("accountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BANKCARD</para>
        /// </summary>
        [NameInMap("accountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("bankCardNo")]
        [Validation(Required=false)]
        public string BankCardNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ICBC</para>
        /// </summary>
        [NameInMap("bankCode")]
        [Validation(Required=false)]
        public string BankCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国工商银行</para>
        /// </summary>
        [NameInMap("bankName")]
        [Validation(Required=false)]
        public string BankName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>账户描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国工商银行余杭分行</para>
        /// </summary>
        [NameInMap("officialName")]
        [Validation(Required=false)]
        public string OfficialName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1128878445</para>
        /// </summary>
        [NameInMap("officialNumber")]
        [Validation(Required=false)]
        public string OfficialNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>smallScaleTaxpayer</para>
        /// </summary>
        [NameInMap("taxNature")]
        [Validation(Required=false)]
        public string TaxNature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>125481254812548</para>
        /// </summary>
        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5046195764756652</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
