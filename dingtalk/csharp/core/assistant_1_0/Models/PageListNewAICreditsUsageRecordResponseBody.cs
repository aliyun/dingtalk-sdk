// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkassistant_1_0.Models
{
    public class PageListNewAICreditsUsageRecordResponseBody : TeaModel {
        [NameInMap("dataList")]
        [Validation(Required=false)]
        public List<PageListNewAICreditsUsageRecordResponseBodyDataList> DataList { get; set; }
        public class PageListNewAICreditsUsageRecordResponseBodyDataList : TeaModel {
            [NameInMap("abilityName")]
            [Validation(Required=false)]
            public string AbilityName { get; set; }

            [NameInMap("aiCreditsUsedNum")]
            [Validation(Required=false)]
            public string AiCreditsUsedNum { get; set; }

            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("isTimeFree")]
            [Validation(Required=false)]
            public string IsTimeFree { get; set; }

            [NameInMap("scenarioName")]
            [Validation(Required=false)]
            public string ScenarioName { get; set; }

            [NameInMap("taskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("usageTime")]
            [Validation(Required=false)]
            public string UsageTime { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
