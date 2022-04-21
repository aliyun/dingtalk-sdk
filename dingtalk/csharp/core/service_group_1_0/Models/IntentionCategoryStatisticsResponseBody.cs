// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class IntentionCategoryStatisticsResponseBody : TeaModel {
        /// <summary>
        /// 统计明细
        /// </summary>
        [NameInMap("intentionCategoryRecords")]
        [Validation(Required=false)]
        public List<IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords> IntentionCategoryRecords { get; set; }
        public class IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords : TeaModel {
            /// <summary>
            /// 求助咨询量
            /// </summary>
            [NameInMap("askCount")]
            [Validation(Required=false)]
            public long? AskCount { get; set; }

            /// <summary>
            /// 分类名
            /// </summary>
            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// 不满辱骂量
            /// </summary>
            [NameInMap("dissatisfiedCount")]
            [Validation(Required=false)]
            public long? DissatisfiedCount { get; set; }

            /// <summary>
            /// 产品异常量
            /// </summary>
            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// 赞扬量
            /// </summary>
            [NameInMap("praiseCount")]
            [Validation(Required=false)]
            public long? PraiseCount { get; set; }

            /// <summary>
            /// 产品建议量
            /// </summary>
            [NameInMap("suggestCount")]
            [Validation(Required=false)]
            public long? SuggestCount { get; set; }

        }

    }

}
