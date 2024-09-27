// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcalendar_1_0.Models
{
    public class AddMeetingRoomsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("meetingRoomsToAdd")]
        [Validation(Required=false)]
        public List<AddMeetingRoomsRequestMeetingRoomsToAdd> MeetingRoomsToAdd { get; set; }
        public class AddMeetingRoomsRequestMeetingRoomsToAdd : TeaModel {
            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

        }

    }

}
