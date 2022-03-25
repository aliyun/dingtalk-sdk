// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class ListEventsRequest : TeaModel {
        /// <summary>
        /// 每个日程的参与者查询个数，默认100，最大100
        /// </summary>
        [NameInMap("maxAttendees")]
        [Validation(Required=false)]
        public int? MaxAttendees { get; set; }

        /// <summary>
        /// 返回的最大日程数，最大100个，默认100个
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 查询翻页token
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 是否返回删除事件
        /// </summary>
        [NameInMap("showDeleted")]
        [Validation(Required=false)]
        public bool? ShowDeleted { get; set; }

        /// <summary>
        /// 增量查询token
        /// </summary>
        [NameInMap("syncToken")]
        [Validation(Required=false)]
        public string SyncToken { get; set; }

        /// <summary>
        /// 查询截止时间
        /// </summary>
        [NameInMap("timeMax")]
        [Validation(Required=false)]
        public string TimeMax { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [NameInMap("timeMin")]
        [Validation(Required=false)]
        public string TimeMin { get; set; }

    }

}
