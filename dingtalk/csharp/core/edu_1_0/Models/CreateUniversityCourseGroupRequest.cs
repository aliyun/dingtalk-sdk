// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateUniversityCourseGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>高数</para>
        /// </summary>
        [NameInMap("courseGroupIntroduce")]
        [Validation(Required=false)]
        public string CourseGroupIntroduce { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张老师_高数</para>
        /// </summary>
        [NameInMap("courseGroupName")]
        [Validation(Required=false)]
        public string CourseGroupName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("courserGroupItemModels")]
        [Validation(Required=false)]
        public List<CreateUniversityCourseGroupRequestCourserGroupItemModels> CourserGroupItemModels { get; set; }
        public class CreateUniversityCourseGroupRequestCourserGroupItemModels : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1、单周；2、双周；3、全周</para>
            /// </summary>
            [NameInMap("classPeriodType")]
            [Validation(Required=false)]
            public int? ClassPeriodType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("classroomId")]
            [Validation(Required=false)]
            public long? ClassroomId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1;音视频直播\2:线下课程\4:音视频及线下</para>
            /// </summary>
            [NameInMap("courseType")]
            [Validation(Required=false)]
            public int? CourseType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("courserGroupItemEndDate")]
            [Validation(Required=false)]
            public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate CourserGroupItemEndDate { get; set; }
            public class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>31</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("courserGroupItemStartDate")]
            [Validation(Required=false)]
            public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate CourserGroupItemStartDate { get; set; }
            public class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("dayOfWeek")]
            [Validation(Required=false)]
            public int? DayOfWeek { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public List<int?> SectionIndex { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GZ1001</para>
        /// </summary>
        [NameInMap("isvCourseGroupCode")]
        [Validation(Required=false)]
        public string IsvCourseGroupCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>大学：university</para>
        /// </summary>
        [NameInMap("periodCode")]
        [Validation(Required=false)]
        public string PeriodCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-2022</para>
        /// </summary>
        [NameInMap("schoolYear")]
        [Validation(Required=false)]
        public string SchoolYear { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("semester")]
        [Validation(Required=false)]
        public int? Semester { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>高等数学</para>
        /// </summary>
        [NameInMap("subjectName")]
        [Validation(Required=false)]
        public string SubjectName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("teacherInfos")]
        [Validation(Required=false)]
        public List<CreateUniversityCourseGroupRequestTeacherInfos> TeacherInfos { get; set; }
        public class CreateUniversityCourseGroupRequestTeacherInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>TEACHER授课教师/TEACHING_ASSISTANT助教</para>
            /// </summary>
            [NameInMap("participantRole")]
            [Validation(Required=false)]
            public string ParticipantRole { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>manger1234</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
