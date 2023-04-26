// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GroupStatisticsResponseBody : TeaModel {
        [NameInMap("groupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        [NameInMap("groupTrend")]
        [Validation(Required=false)]
        public List<GroupStatisticsResponseBodyGroupTrend> GroupTrend { get; set; }
        public class GroupStatisticsResponseBodyGroupTrend : TeaModel {
            [NameInMap("count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

        }

        [NameInMap("increaseGroupCount")]
        [Validation(Required=false)]
        public long? IncreaseGroupCount { get; set; }

        [NameInMap("increaseRate")]
        [Validation(Required=false)]
        public string IncreaseRate { get; set; }

    }

}
