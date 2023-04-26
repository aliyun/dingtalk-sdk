// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateRemoteClassCourseRequest : TeaModel {
        [NameInMap("attendParticipants")]
        [Validation(Required=false)]
        public List<UpdateRemoteClassCourseRequestAttendParticipants> AttendParticipants { get; set; }
        public class UpdateRemoteClassCourseRequestAttendParticipants : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("participantId")]
            [Validation(Required=false)]
            public string ParticipantId { get; set; }

        }

        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        [NameInMap("courseCode")]
        [Validation(Required=false)]
        public string CourseCode { get; set; }

        [NameInMap("courseName")]
        [Validation(Required=false)]
        public string CourseName { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("teachingParticipant")]
        [Validation(Required=false)]
        public UpdateRemoteClassCourseRequestTeachingParticipant TeachingParticipant { get; set; }
        public class UpdateRemoteClassCourseRequestTeachingParticipant : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("participantId")]
            [Validation(Required=false)]
            public string ParticipantId { get; set; }

        }

    }

}
