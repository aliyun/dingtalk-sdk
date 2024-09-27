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
                /// <summary>
                /// <b>Example:</b>
                /// <para>ding23456</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>组织234</para>
                /// </summary>
                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>865306</para>
                /// </summary>
                [NameInMap("participantId")]
                [Validation(Required=false)]
                public string ParticipantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>二年级1班</para>
                /// </summary>
                [NameInMap("participantName")]
                [Validation(Required=false)]
                public string ParticipantName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("canEdit")]
            [Validation(Required=false)]
            public bool? CanEdit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>UvCIp16813006</para>
            /// </summary>
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>春天来了</para>
            /// </summary>
            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1635157800000</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://pre-live.edu.dingtalk.com/live/showLive?courseCode=UvCIp16813006#/aiclass">https://pre-live.edu.dingtalk.com/live/showLive?courseCode=UvCIp16813006#/aiclass</a></para>
            /// </summary>
            [NameInMap("liveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            [NameInMap("recordInfos")]
            [Validation(Required=false)]
            public List<GetRemoteClassCourseResponseBodyResultRecordInfos> RecordInfos { get; set; }
            public class GetRemoteClassCourseResponseBodyResultRecordInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-11-17T02:08:45Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-11-17T04:08:45Z</para>
                /// </summary>
                [NameInMap("stopTime")]
                [Validation(Required=false)]
                public string StopTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://oss.xxx.com/xxxx">http://oss.xxx.com/xxxx</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("roomStatus")]
            [Validation(Required=false)]
            public int? RoomStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1635150600000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("teachingParticipant")]
            [Validation(Required=false)]
            public GetRemoteClassCourseResponseBodyResultTeachingParticipant TeachingParticipant { get; set; }
            public class GetRemoteClassCourseResponseBodyResultTeachingParticipant : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ding1234</para>
                /// </summary>
                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>组织123</para>
                /// </summary>
                [NameInMap("orgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>881436</para>
                /// </summary>
                [NameInMap("participantId")]
                [Validation(Required=false)]
                public string ParticipantId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>一年级1班</para>
                /// </summary>
                [NameInMap("participantName")]
                [Validation(Required=false)]
                public string ParticipantName { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
