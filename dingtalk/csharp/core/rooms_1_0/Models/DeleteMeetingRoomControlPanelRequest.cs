// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class DeleteMeetingRoomControlPanelRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public DeleteMeetingRoomControlPanelRequestBody Body { get; set; }
        public class DeleteMeetingRoomControlPanelRequestBody : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("roomIds")]
            [Validation(Required=false)]
            public List<string> RoomIds { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
