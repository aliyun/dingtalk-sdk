// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontact_1_0.Models
{
    public class GetLatestDingIndexResponseBody : TeaModel {
        [NameInMap("idxCarbon")]
        [Validation(Required=false)]
        public float? IdxCarbon { get; set; }

        [NameInMap("idxEfficiency")]
        [Validation(Required=false)]
        public float? IdxEfficiency { get; set; }

        [NameInMap("idxMonthlyAvg")]
        [Validation(Required=false)]
        public float? IdxMonthlyAvg { get; set; }

        [NameInMap("idxTotal")]
        [Validation(Required=false)]
        public float? IdxTotal { get; set; }

        [NameInMap("statDate")]
        [Validation(Required=false)]
        public string StatDate { get; set; }

    }

}
