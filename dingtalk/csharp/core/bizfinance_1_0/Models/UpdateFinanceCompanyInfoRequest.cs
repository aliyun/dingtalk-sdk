// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class UpdateFinanceCompanyInfoRequest : TeaModel {
        /// <summary>
        /// 公司名字
        /// </summary>
        [NameInMap("companyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// 纳税性质 小规模纳税人 一般纳税人
        /// </summary>
        [NameInMap("taxNature")]
        [Validation(Required=false)]
        public string TaxNature { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

    }

}
