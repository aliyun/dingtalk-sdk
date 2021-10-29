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
                public string ParticipantId { get; set; }
                public string ParticipantName { get; set; }
                public string CorpId { get; set; }
                public string OrgName { get; set; }
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
                /// <summary>
                /// 组织ID
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// 组织名称
                /// </summary>
                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                /// <summary>
                /// 参与方ID
                /// </summary>
                [NameInMap("participantId")]
                [Validation(Required=false)]
                public string ParticipantId { get; set; }

                /// <summary>
                /// 参与方名称
                /// </summary>
                [NameInMap("participantName")]
                [Validation(Required=false)]
                public string ParticipantName { get; set; }

            }
        };

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
