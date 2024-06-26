// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateFinanceMultiCompanyInfoRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("companyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        [NameInMap("taxNature")]
        [Validation(Required=false)]
        public string TaxNature { get; set; }

        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

        [NameInMap("taxOrInvoiceHasInit")]
        [Validation(Required=false)]
        public bool? TaxOrInvoiceHasInit { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
