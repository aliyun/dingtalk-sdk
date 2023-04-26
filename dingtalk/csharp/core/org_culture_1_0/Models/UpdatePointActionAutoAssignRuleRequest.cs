// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class UpdatePointActionAutoAssignRuleRequest : TeaModel {
        [NameInMap("updatePointRuleRequestDTOList")]
        [Validation(Required=false)]
        public List<UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList> UpdatePointRuleRequestDTOList { get; set; }
        public class UpdatePointActionAutoAssignRuleRequestUpdatePointRuleRequestDTOList : TeaModel {
            [NameInMap("awardScore")]
            [Validation(Required=false)]
            public long? AwardScore { get; set; }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("dayLimitTimes")]
            [Validation(Required=false)]
            public long? DayLimitTimes { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
