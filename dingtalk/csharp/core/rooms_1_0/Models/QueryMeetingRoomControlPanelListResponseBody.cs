// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrooms_1_0.Models
{
    public class QueryMeetingRoomControlPanelListResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryMeetingRoomControlPanelListResponseBodyResult> Result { get; set; }
        public class QueryMeetingRoomControlPanelListResponseBodyResult : TeaModel {
            [NameInMap("roomId")]
            [Validation(Required=false)]
            public string RoomId { get; set; }

            [NameInMap("roomIotConfig")]
            [Validation(Required=false)]
            public List<QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig> RoomIotConfig { get; set; }
            public class QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig : TeaModel {
                [NameInMap("enName")]
                [Validation(Required=false)]
                public string EnName { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("showTime")]
                [Validation(Required=false)]
                public int? ShowTime { get; set; }

                [NameInMap("sort")]
                [Validation(Required=false)]
                public int? Sort { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
