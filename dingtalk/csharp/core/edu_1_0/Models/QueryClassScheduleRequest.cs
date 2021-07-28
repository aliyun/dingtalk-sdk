// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleRequest : TeaModel {
        /// <summary>
        /// 订阅者类型：  DEPARTMENT：班级订阅 USER：老师订阅
        /// </summary>
        [NameInMap("subscriberType")]
        [Validation(Required=false)]
        public string SubscriberType { get; set; }

        /// <summary>
        /// 开始时间（unix时间戳）
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 结束时间（unix时间戳）
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 操作者UserId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// 订阅者的Id。
        /// </summary>
        [NameInMap("subscriberIds")]
        [Validation(Required=false)]
        public List<string> SubscriberIds { get; set; }

        /// <summary>
        /// 查询课程的节次。
        /// </summary>
        [NameInMap("sectionIndexList")]
        [Validation(Required=false)]
        public List<long?> SectionIndexList { get; set; }

    }

}
