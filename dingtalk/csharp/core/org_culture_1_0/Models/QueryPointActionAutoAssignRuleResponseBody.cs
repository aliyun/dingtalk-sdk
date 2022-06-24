// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class QueryPointActionAutoAssignRuleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryPointActionAutoAssignRuleResponseBodyResult Result { get; set; }
        public class QueryPointActionAutoAssignRuleResponseBodyResult : TeaModel {
            [NameInMap("queryPointRuleResponseDTOS")]
            [Validation(Required=false)]
            public List<QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS> QueryPointRuleResponseDTOS { get; set; }
            public class QueryPointActionAutoAssignRuleResponseBodyResultQueryPointRuleResponseDTOS : TeaModel {
                public long? AwardScore { get; set; }
                public string Code { get; set; }
                public long? DayLimitTimes { get; set; }
                public string Description { get; set; }
                public long? Status { get; set; }
            }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
