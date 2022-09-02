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
            /// <summary>
            /// 听课设备列表
            /// </summary>
            [NameInMap("attendParticipants")]
            [Validation(Required=false)]
            public List<GetRemoteClassCourseResponseBodyResultAttendParticipants> AttendParticipants { get; set; }
            public class GetRemoteClassCourseResponseBodyResultAttendParticipants : TeaModel {
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
            /// 结束时间
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 直播观看URL（如果有）
            /// </summary>
            [NameInMap("liveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            /// <summary>
            /// 录制信息列表（如果有）。根据录制端的不同，有不同时长的延迟
            /// </summary>
            [NameInMap("recordInfos")]
            [Validation(Required=false)]
            public List<GetRemoteClassCourseResponseBodyResultRecordInfos> RecordInfos { get; set; }
            public class GetRemoteClassCourseResponseBodyResultRecordInfos : TeaModel {
                /// <summary>
                /// 录制开始时间（UTC/GMT格式）
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// 录制结束时间（UTC/GMT格式）
                /// </summary>
                [NameInMap("stopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// 录制文件地址（文件有效期7天）
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// 课堂当前状态：0: 未进行；1: 进行中
            /// </summary>
            [NameInMap("roomStatus")]
            [Validation(Required=false)]
            public int? RoomStatus { get; set; }

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

        }

        /// <summary>
        /// 是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
