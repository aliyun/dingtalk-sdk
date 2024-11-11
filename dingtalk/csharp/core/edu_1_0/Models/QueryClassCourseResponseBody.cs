// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassCourseResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryClassCourseResponseBodyResult Result { get; set; }
        public class QueryClassCourseResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>class_xxx</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public string ClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>一年级一班</para>
            /// </summary>
            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>classroom_xxx</para>
            /// </summary>
            [NameInMap("classRoomId")]
            [Validation(Required=false)]
            public string ClassRoomId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>音乐教室</para>
            /// </summary>
            [NameInMap("classRoomName")]
            [Validation(Required=false)]
            public string ClassRoomName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("classType")]
            [Validation(Required=false)]
            public int? ClassType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding_xxx</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>course_xxx</para>
            /// </summary>
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("courseDate")]
            [Validation(Required=false)]
            public long? CourseDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>语文</para>
            /// </summary>
            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("courseWeek")]
            [Validation(Required=false)]
            public int? CourseWeek { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>isv_xxx</para>
            /// </summary>
            [NameInMap("isvCode")]
            [Validation(Required=false)]
            public string IsvCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>course_xxx</para>
            /// </summary>
            [NameInMap("isvCourseId")]
            [Validation(Required=false)]
            public string IsvCourseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>memo</para>
            /// </summary>
            [NameInMap("memo")]
            [Validation(Required=false)]
            public string Memo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024</para>
            /// </summary>
            [NameInMap("schoolYear")]
            [Validation(Required=false)]
            public string SchoolYear { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("semester")]
            [Validation(Required=false)]
            public int? Semester { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("teachWeek")]
            [Validation(Required=false)]
            public int? TeachWeek { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>第一节</para>
            /// </summary>
            [NameInMap("timeslotName")]
            [Validation(Required=false)]
            public string TimeslotName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("timeslotNum")]
            [Validation(Required=false)]
            public int? TimeslotNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
