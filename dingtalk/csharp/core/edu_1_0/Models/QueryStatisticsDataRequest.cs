// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryStatisticsDataRequest : TeaModel {
        /// <summary>
        /// 课程节次列表
        /// </summary>
        [NameInMap("sectionIndexList")]
        [Validation(Required=false)]
        public List<long?> SectionIndexList { get; set; }

        /// <summary>
        /// 老师UserIds
        /// </summary>
        [NameInMap("teacherUserIds")]
        [Validation(Required=false)]
        public List<string> TeacherUserIds { get; set; }

        /// <summary>
        /// endTime
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// opUserId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// startTime
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
