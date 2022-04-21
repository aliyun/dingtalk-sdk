// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GroupStatisticsResponseBody : TeaModel {
        /// <summary>
        /// (本期)群总数
        /// </summary>
        [NameInMap("groupCount")]
        [Validation(Required=false)]
        public long? GroupCount { get; set; }

        /// <summary>
        /// 群趋势
        /// </summary>
        [NameInMap("groupTrend")]
        [Validation(Required=false)]
        public List<GroupStatisticsResponseBodyGroupTrend> GroupTrend { get; set; }
        public class GroupStatisticsResponseBodyGroupTrend : TeaModel {
            /// <summary>
            /// 群数量
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

        }

        /// <summary>
        /// 较上期增长数
        /// </summary>
        [NameInMap("increaseGroupCount")]
        [Validation(Required=false)]
        public long? IncreaseGroupCount { get; set; }

        /// <summary>
        /// 较上期增长率(已乘以100）
        /// </summary>
        [NameInMap("increaseRate")]
        [Validation(Required=false)]
        public string IncreaseRate { get; set; }

    }

}
