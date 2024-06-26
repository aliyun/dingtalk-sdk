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
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("awardScore")]
                [Validation(Required=false)]
                public long? AwardScore { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dayLimitTimes")]
                [Validation(Required=false)]
                public long? DayLimitTimes { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
