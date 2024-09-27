// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateFinanceMultiCompanyInfoRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COM_DEFAULT</para>
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>钉钉</para>
        /// </summary>
        [NameInMap("companyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>generalTaxpayer</para>
        /// </summary>
        [NameInMap("taxNature")]
        [Validation(Required=false)]
        public string TaxNature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789012345</para>
        /// </summary>
        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        [NameInMap("taxOrInvoiceHasInit")]
        [Validation(Required=false)]
        public bool? TaxOrInvoiceHasInit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
