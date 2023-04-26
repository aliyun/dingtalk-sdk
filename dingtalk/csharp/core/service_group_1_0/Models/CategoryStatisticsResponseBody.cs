// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class CategoryStatisticsResponseBody : TeaModel {
        [NameInMap("categoryStatisticsRecords")]
        [Validation(Required=false)]
        public List<CategoryStatisticsResponseBodyCategoryStatisticsRecords> CategoryStatisticsRecords { get; set; }
        public class CategoryStatisticsResponseBodyCategoryStatisticsRecords : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("lastCount")]
            [Validation(Required=false)]
            public long? LastCount { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("categoryTrend")]
        [Validation(Required=false)]
        public List<CategoryStatisticsResponseBodyCategoryTrend> CategoryTrend { get; set; }
        public class CategoryStatisticsResponseBodyCategoryTrend : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
