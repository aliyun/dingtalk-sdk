// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateRemoteClassCourseRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("attendParticipants")]
        [Validation(Required=false)]
        public List<UpdateRemoteClassCourseRequestAttendParticipants> AttendParticipants { get; set; }
        public class UpdateRemoteClassCourseRequestAttendParticipants : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ding234567</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>234567</para>
            /// </summary>
            [NameInMap("participantId")]
            [Validation(Required=false)]
            public string ParticipantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("authCode")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qdPP123456</para>
        /// </summary>
        [NameInMap("courseCode")]
        [Validation(Required=false)]
        public string CourseCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>春天来了</para>
        /// </summary>
        [NameInMap("courseName")]
        [Validation(Required=false)]
        public string CourseName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634184000000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634176800000</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("teachingParticipant")]
        [Validation(Required=false)]
        public UpdateRemoteClassCourseRequestTeachingParticipant TeachingParticipant { get; set; }
        public class UpdateRemoteClassCourseRequestTeachingParticipant : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ding123456</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("participantId")]
            [Validation(Required=false)]
            public string ParticipantId { get; set; }

        }

    }

}
