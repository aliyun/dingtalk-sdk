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
            /// <summary>
            /// 听课设备列表
            /// </summary>
            [NameInMap("attendParticipants")]
            [Validation(Required=false)]
            public List<QueryRemoteClassCourseResponseBodyResultAttendParticipants> AttendParticipants { get; set; }
            public class QueryRemoteClassCourseResponseBodyResultAttendParticipants : TeaModel {
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

            /// <summary>
            /// 课程是否可以编辑或删除
            /// </summary>
            [NameInMap("canEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

            /// <summary>
            /// 课程code
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

            /// <summary>
            /// 当前组织在课程中的角色列表：TEACHING：授课方；ATTEND：听课方
            /// </summary>
            [NameInMap("courseWays")]
            [Validation(Required=false)]
            public List<string> CourseWays { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 课程状态：0: 未开始；1: 已开始；2: 已结束
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 授课设备
            /// </summary>
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
            };

        }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
