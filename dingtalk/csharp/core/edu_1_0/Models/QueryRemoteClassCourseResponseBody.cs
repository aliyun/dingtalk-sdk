// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryRemoteClassCourseResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryRemoteClassCourseResponseBodyResult> Result { get; set; }
        public class QueryRemoteClassCourseResponseBodyResult : TeaModel {
            [NameInMap("attendParticipants")]
            [Validation(Required=false)]
            public List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> AttendParticipants { get; set; }
            public class QueryRemoteClassCourseResponseBodyResultAttendParticipants : TeaModel {
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

            [NameInMap("courseWays")]
            [Validation(Required=false)]
            public List<string> CourseWays { get; set; }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("teachingParticipant")]
            [Validation(Required=false)]
            public QueryRemoteClassCourseResponseBodyResultTeachingParticipant TeachingParticipant { get; set; }
            public class QueryRemoteClassCourseResponseBodyResultTeachingParticipant : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
