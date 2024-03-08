// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class PagesExportInstancesRequest : TeaModel {
        [NameInMap("endTimeInMills")]
        [Validation(Required=false)]
        public long? EndTimeInMills { get; set; }

        [NameInMap("maxResult")]
        [Validation(Required=false)]
        public int? MaxResult { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("orderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("processCode")]
        [Validation(Required=false)]
        public string ProcessCode { get; set; }

        [NameInMap("startTimeInMills")]
        [Validation(Required=false)]
        public long? StartTimeInMills { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
