// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateRemoteClassCourseRequest : TeaModel {
        /// <summary>
        /// 听课设备
        /// </summary>
        [NameInMap("attendParticipants")]
        [Validation(Required=false)]
        public List<UpdateRemoteClassCourseRequestAttendParticipants> AttendParticipants { get; set; }
        public class UpdateRemoteClassCourseRequestAttendParticipants : TeaModel {
            /// <summary>
            /// 参与方ID
            /// </summary>
            [NameInMap("participantId")]
            [Validation(Required=false)]
            public string ParticipantId { get; set; }

            /// <summary>
            /// 组织ID
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

        }

        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// 课程码
        /// </summary>
        [NameInMap("courseCode")]
        [Validation(Required=false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [NameInMap("courseName")]
        [Validation(Required=false)]
        public string CourseName { get; set; }

        [NameInMap("dingClientId")]
        [Validation(Required=false)]
        public string DingClientId { get; set; }

        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOauthAppId")]
        [Validation(Required=false)]
        public long? DingOauthAppId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public int? DingTokenGrantType { get; set; }

        /// <summary>
        /// 课程结束时间
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 课程开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 授课设备
        /// </summary>
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
        };

    }

}
