// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkokr_1_0.Models
{
    public class OpenPeriodDTO : TeaModel {
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        [NameInMap("nameCn")]
        [Validation(Required=false)]
        public string NameCn { get; set; }

        [NameInMap("nameEn")]
        [Validation(Required=false)]
        public string NameEn { get; set; }

        [NameInMap("periodId")]
        [Validation(Required=false)]
        public string PeriodId { get; set; }

        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
