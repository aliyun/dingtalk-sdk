// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetRemoteClassCourseResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetRemoteClassCourseResponseBodyResult Result { get; set; }
        public class GetRemoteClassCourseResponseBodyResult : TeaModel {
            [NameInMap("attendParticipants")]
            [Validation(Required=false)]
            public List<GetRemoteClassCourseResponseBodyResultAttendParticipants> AttendParticipants { get; set; }
            public class GetRemoteClassCourseResponseBodyResultAttendParticipants : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                [NameInMap("participantId")]
                [Validation(Required=false)]
                public string ParticipantId { get; set; }

                [NameInMap("participantName")]
                [Validation(Required=false)]
                public string ParticipantName { get; set; }

            }

            [NameInMap("canEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("liveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            [NameInMap("recordInfos")]
            [Validation(Required=false)]
            public List<GetRemoteClassCourseResponseBodyResultRecordInfos> RecordInfos { get; set; }
            public class GetRemoteClassCourseResponseBodyResultRecordInfos : TeaModel {
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("stopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("roomStatus")]
            [Validation(Required=false)]
            public int? RoomStatus { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("teachingParticipant")]
            [Validation(Required=false)]
            public GetRemoteClassCourseResponseBodyResultTeachingParticipant TeachingParticipant { get; set; }
            public class GetRemoteClassCourseResponseBodyResultTeachingParticipant : TeaModel {
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                [NameInMap("participantId")]
                [Validation(Required=false)]
                public string ParticipantId { get; set; }

                [NameInMap("participantName")]
                [Validation(Required=false)]
                public string ParticipantName { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
