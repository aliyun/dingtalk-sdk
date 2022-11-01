// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class RemoveMeetingRoomsRequest : TeaModel {
        [NameInMap("meetingRoomsToRemove")]
        [Validation(Required=false)]
        public List<RemoveMeetingRoomsRequestMeetingRoomsToRemove> MeetingRoomsToRemove { get; set; }
        public class RemoveMeetingRoomsRequestMeetingRoomsToRemove : TeaModel {
            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

        }

    }

}
