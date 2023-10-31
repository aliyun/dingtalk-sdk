// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcredit_1_0.Models
{
    public class QueryScoreResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryScoreResponseBodyResult Result { get; set; }
        public class QueryScoreResponseBodyResult : TeaModel {
            [NameInMap("ccocScore")]
            [Validation(Required=false)]
            public double? CcocScore { get; set; }

            [NameInMap("cityChangeCnt3y")]
            [Validation(Required=false)]
            public long? CityChangeCnt3y { get; set; }

            [NameInMap("cityChangeTrend2y")]
            [Validation(Required=false)]
            public double? CityChangeTrend2y { get; set; }

            [NameInMap("classificationOfOrg")]
            [Validation(Required=false)]
            public string ClassificationOfOrg { get; set; }

            [NameInMap("growthRateLoginDays180d")]
            [Validation(Required=false)]
            public double? GrowthRateLoginDays180d { get; set; }

            [NameInMap("indChangeCnt3y")]
            [Validation(Required=false)]
            public long? IndChangeCnt3y { get; set; }

            [NameInMap("indChangeTrend2y")]
            [Validation(Required=false)]
            public double? IndChangeTrend2y { get; set; }

            [NameInMap("jobChangeCnt3y")]
            [Validation(Required=false)]
            public long? JobChangeCnt3y { get; set; }

            [NameInMap("jobTitle")]
            [Validation(Required=false)]
            public string JobTitle { get; set; }

            [NameInMap("joinDays")]
            [Validation(Required=false)]
            public long? JoinDays { get; set; }

            [NameInMap("loginDays14dPct")]
            [Validation(Required=false)]
            public double? LoginDays14dPct { get; set; }

            [NameInMap("loginDays365dPct")]
            [Validation(Required=false)]
            public double? LoginDays365dPct { get; set; }

            [NameInMap("orgCnt")]
            [Validation(Required=false)]
            public long? OrgCnt { get; set; }

            [NameInMap("orgIndustrySubNameNew")]
            [Validation(Required=false)]
            public string OrgIndustrySubNameNew { get; set; }

            [NameInMap("orgIndustryUpNameNew")]
            [Validation(Required=false)]
            public string OrgIndustryUpNameNew { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
