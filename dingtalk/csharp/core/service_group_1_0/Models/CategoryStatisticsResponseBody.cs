// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CategoryStatisticsResponseBody : TeaModel {
        /// <summary>
        /// 分类统计
        /// </summary>
        [NameInMap("categoryStatisticsRecords")]
        [Validation(Required=false)]
        public List<CategoryStatisticsResponseBodyCategoryStatisticsRecords> CategoryStatisticsRecords { get; set; }
        public class CategoryStatisticsResponseBodyCategoryStatisticsRecords : TeaModel {
            /// <summary>
            /// 心声数量
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// 上期心声数量
            /// </summary>
            [NameInMap("lastCount")]
            [Validation(Required=false)]
            public long? LastCount { get; set; }

            /// <summary>
            /// 分类名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// 分类趋势
        /// </summary>
        [NameInMap("categoryTrend")]
        [Validation(Required=false)]
        public List<CategoryStatisticsResponseBodyCategoryTrend> CategoryTrend { get; set; }
        public class CategoryStatisticsResponseBodyCategoryTrend : TeaModel {
            /// <summary>
            /// 心声数量
            /// </summary>
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// 日期
            /// </summary>
            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            /// <summary>
            /// 分类名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
