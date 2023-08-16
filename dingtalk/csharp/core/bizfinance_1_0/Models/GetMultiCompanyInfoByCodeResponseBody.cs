// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetMultiCompanyInfoByCodeResponseBody : TeaModel {
        [NameInMap("advancedSettingList")]
        [Validation(Required=false)]
        public List<GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList> AdvancedSettingList { get; set; }
        public class GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList : TeaModel {
            [NameInMap("advancedSettingKey")]
            [Validation(Required=false)]
            public string AdvancedSettingKey { get; set; }

            [NameInMap("advancedSettingName")]
            [Validation(Required=false)]
            public string AdvancedSettingName { get; set; }

            [NameInMap("endDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public bool? Value { get; set; }

        }

        [NameInMap("companyCode")]
        [Validation(Required=false)]
        public string CompanyCode { get; set; }

        [NameInMap("companyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("taxNature")]
        [Validation(Required=false)]
        public string TaxNature { get; set; }

        [NameInMap("taxNo")]
        [Validation(Required=false)]
        public string TaxNo { get; set; }

    }

}
