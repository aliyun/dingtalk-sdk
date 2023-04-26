// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class AddCityCarApplyRequest : TeaModel {
        [NameInMap("cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        [NameInMap("finishedDate")]
        [Validation(Required=false)]
        public string FinishedDate { get; set; }

        [NameInMap("projectCode")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("projectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        [NameInMap("thirdPartApplyId")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        [NameInMap("thirdPartCostCenterId")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        [NameInMap("thirdPartInvoiceId")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

        [NameInMap("timesTotal")]
        [Validation(Required=false)]
        public long? TimesTotal { get; set; }

        [NameInMap("timesType")]
        [Validation(Required=false)]
        public long? TimesType { get; set; }

        [NameInMap("timesUsed")]
        [Validation(Required=false)]
        public long? TimesUsed { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
