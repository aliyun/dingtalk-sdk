// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class IntentionCategoryStatisticsResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("intentionCategoryRecords")]
        [Validation(Required=false)]
        public List<IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords> IntentionCategoryRecords { get; set; }
        public class IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("askCount")]
            [Validation(Required=false)]
            public long? AskCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dissatisfiedCount")]
            [Validation(Required=false)]
            public long? DissatisfiedCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("praiseCount")]
            [Validation(Required=false)]
            public long? PraiseCount { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("suggestCount")]
            [Validation(Required=false)]
            public long? SuggestCount { get; set; }

        }

    }

}
