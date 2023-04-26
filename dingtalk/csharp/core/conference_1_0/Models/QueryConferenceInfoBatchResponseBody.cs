// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkconference_1_0.Models
{
    public class QueryConferenceInfoBatchResponseBody : TeaModel {
        [NameInMap("infos")]
        [Validation(Required=false)]
        public List<QueryConferenceInfoBatchResponseBodyInfos> Infos { get; set; }
        public class QueryConferenceInfoBatchResponseBodyInfos : TeaModel {
            [NameInMap("conferenceId")]
            [Validation(Required=false)]
            public string ConferenceId { get; set; }

            [NameInMap("mediaStatus")]
            [Validation(Required=false)]
            public long? MediaStatus { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("userList")]
            [Validation(Required=false)]
            public List<QueryConferenceInfoBatchResponseBodyInfosUserList> UserList { get; set; }
            public class QueryConferenceInfoBatchResponseBodyInfosUserList : TeaModel {
                [NameInMap("attendStatus")]
                [Validation(Required=false)]
                public long? AttendStatus { get; set; }

                [NameInMap("cameraStatus")]
                [Validation(Required=false)]
                public long? CameraStatus { get; set; }

                [NameInMap("micStatus")]
                [Validation(Required=false)]
                public long? MicStatus { get; set; }

                [NameInMap("nick")]
                [Validation(Required=false)]
                public string Nick { get; set; }

                [NameInMap("rejectDescription")]
                [Validation(Required=false)]
                public string RejectDescription { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
