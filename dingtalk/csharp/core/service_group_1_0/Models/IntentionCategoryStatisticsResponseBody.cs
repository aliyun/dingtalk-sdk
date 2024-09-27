// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class IntentionCategoryStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("intentionCategoryRecords")]
        [Validation(Required=false)]
        public List<IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords> IntentionCategoryRecords { get; set; }
        public class IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("askCount")]
            [Validation(Required=false)]
            public long? AskCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>工单类</para>
            /// </summary>
            [NameInMap("categoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("dissatisfiedCount")]
            [Validation(Required=false)]
            public long? DissatisfiedCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("errorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("praiseCount")]
            [Validation(Required=false)]
            public long? PraiseCount { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("suggestCount")]
            [Validation(Required=false)]
            public long? SuggestCount { get; set; }

        }

    }

}
