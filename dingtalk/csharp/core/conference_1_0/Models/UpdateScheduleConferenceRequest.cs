// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class UpdateScheduleConferenceRequest : TeaModel {
        [NameInMap("creatorUnionId")]
        [Validation(Required=false)]
        public string CreatorUnionId { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("scheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
