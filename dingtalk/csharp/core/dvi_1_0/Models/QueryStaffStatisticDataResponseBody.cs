// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class QueryStaffStatisticDataResponseBody : TeaModel {
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryStaffStatisticDataResponseBodyResult> Result { get; set; }
        public class QueryStaffStatisticDataResponseBodyResult : TeaModel {
            [NameInMap("averageQualityInspectionScorePerService")]
            [Validation(Required=false)]
            public double? AverageQualityInspectionScorePerService { get; set; }

            [NameInMap("day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            [NameInMap("highestQualityInspectionScore")]
            [Validation(Required=false)]
            public double? HighestQualityInspectionScore { get; set; }

            [NameInMap("saleSopPercentage")]
            [Validation(Required=false)]
            public Dictionary<string, object> SaleSopPercentage { get; set; }

            [NameInMap("serviceRecordCount")]
            [Validation(Required=false)]
            public long? ServiceRecordCount { get; set; }

            [NameInMap("staffName")]
            [Validation(Required=false)]
            public string StaffName { get; set; }

            [NameInMap("teamCode")]
            [Validation(Required=false)]
            public string TeamCode { get; set; }

            [NameInMap("teamName")]
            [Validation(Required=false)]
            public string TeamName { get; set; }

            [NameInMap("totalServiceTime")]
            [Validation(Required=false)]
            public long? TotalServiceTime { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
