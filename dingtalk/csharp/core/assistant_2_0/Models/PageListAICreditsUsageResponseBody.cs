// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_2_0.Models
{
    public class PageListAICreditsUsageResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<PageListAICreditsUsageResponseBodyDataList> DataList { get; set; }
        public class PageListAICreditsUsageResponseBodyDataList : TeaModel {
            [NameInMap("abilityName")]
            [Validation(Required=false)]
            public string AbilityName { get; set; }

            [NameInMap("aiCreditsUsedNum")]
            [Validation(Required=false)]
            public double? AiCreditsUsedNum { get; set; }

            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("isTimeFree")]
            [Validation(Required=false)]
            public bool? IsTimeFree { get; set; }

            [NameInMap("scenarioName")]
            [Validation(Required=false)]
            public string ScenarioName { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("usageTime")]
            [Validation(Required=false)]
            public string UsageTime { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
