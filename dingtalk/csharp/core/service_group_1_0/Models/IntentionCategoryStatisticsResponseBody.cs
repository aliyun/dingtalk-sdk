// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class IntentionCategoryStatisticsResponseBody : TeaModel {
        [NameInMap("intentionCategoryRecords")]
        [Validation(Required=false)]
        public List<IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords> IntentionCategoryRecords { get; set; }
        public class IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords : TeaModel {
            [NameInMap("askCount")]
            [Validation(Required=false)]
            public long? AskCount { get; set; }

            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("dissatisfiedCount")]
            [Validation(Required=false)]
            public long? DissatisfiedCount { get; set; }

            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            [NameInMap("praiseCount")]
            [Validation(Required=false)]
            public long? PraiseCount { get; set; }

            [NameInMap("suggestCount")]
            [Validation(Required=false)]
            public long? SuggestCount { get; set; }

        }

    }

}
