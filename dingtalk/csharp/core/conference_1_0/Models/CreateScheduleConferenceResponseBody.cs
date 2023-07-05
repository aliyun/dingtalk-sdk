// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class CreateScheduleConferenceResponseBody : TeaModel {
        [NameInMap("phones")]
        [Validation(Required=false)]
        public List<string> Phones { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("roomCode")]
        [Validation(Required=false)]
        public string RoomCode { get; set; }

        [NameInMap("scheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
