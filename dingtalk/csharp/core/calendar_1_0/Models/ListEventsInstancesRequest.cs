// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsInstancesRequest : TeaModel {
        /// <summary>
        /// listInstances每个日程的参与者查询个数，默认100，最大100。
        /// </summary>
        [NameInMap("maxAttendees")]
        [Validation(Required=false)]
        public long? MaxAttendees { get; set; }

        /// <summary>
        /// listInstances返回的最大日程数，最大100个，默认100个。
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 循环主日程id。
        /// </summary>
        [NameInMap("seriesMasterId")]
        [Validation(Required=false)]
        public string SeriesMasterId { get; set; }

        /// <summary>
        /// 大于此时间的所有生成实例
        /// </summary>
        [NameInMap("timeMin")]
        [Validation(Required=false)]
        public string TimeMin { get; set; }

    }

}
