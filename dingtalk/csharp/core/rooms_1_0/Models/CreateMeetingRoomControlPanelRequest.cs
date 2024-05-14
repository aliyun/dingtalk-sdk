// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class CreateMeetingRoomControlPanelRequest : TeaModel {
        [NameInMap("extra")]
        [Validation(Required=false)]
        public CreateMeetingRoomControlPanelRequestExtra Extra { get; set; }
        public class CreateMeetingRoomControlPanelRequestExtra : TeaModel {
            [NameInMap("param")]
            [Validation(Required=false)]
            public Dictionary<string, string> Param { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roomConfig")]
        [Validation(Required=false)]
        public List<CreateMeetingRoomControlPanelRequestRoomConfig> RoomConfig { get; set; }
        public class CreateMeetingRoomControlPanelRequestRoomConfig : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("enName")]
            [Validation(Required=false)]
            public string EnName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("showTime")]
            [Validation(Required=false)]
            public int? ShowTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sort")]
            [Validation(Required=false)]
            public int? Sort { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("roomId")]
        [Validation(Required=false)]
        public string RoomId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
