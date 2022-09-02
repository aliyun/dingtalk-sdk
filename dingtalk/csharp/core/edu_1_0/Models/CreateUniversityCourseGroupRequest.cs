// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateUniversityCourseGroupRequest : TeaModel {
        /// <summary>
        /// 课程组介绍
        /// </summary>
        [NameInMap("courseGroupIntroduce")]
        [Validation(Required=false)]
        public string CourseGroupIntroduce { get; set; }

        /// <summary>
        /// 课程组名称
        /// </summary>
        [NameInMap("courseGroupName")]
        [Validation(Required=false)]
        public string CourseGroupName { get; set; }

        /// <summary>
        /// 课程详细
        /// </summary>
        [NameInMap("courserGroupItemModels")]
        [Validation(Required=false)]
        public List<CreateUniversityCourseGroupRequestCourserGroupItemModels> CourserGroupItemModels { get; set; }
        public class CreateUniversityCourseGroupRequestCourserGroupItemModels : TeaModel {
            /// <summary>
            /// 上课周期
            /// </summary>
            [NameInMap("classPeriodType")]
            [Validation(Required=false)]
            public int? ClassPeriodType { get; set; }

            /// <summary>
            /// 教室id
            /// </summary>
            [NameInMap("classroomId")]
            [Validation(Required=false)]
            public long? ClassroomId { get; set; }

            /// <summary>
            /// 课程类型
            /// </summary>
            [NameInMap("courseType")]
            [Validation(Required=false)]
            public int? CourseType { get; set; }

            /// <summary>
            /// 课程组详细结束时间
            /// </summary>
            [NameInMap("courserGroupItemEndDate")]
            [Validation(Required=false)]
            public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate CourserGroupItemEndDate { get; set; }
            public class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate : TeaModel {
                /// <summary>
                /// 一月的第几天
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// 课程组详细开始时间
            /// </summary>
            [NameInMap("courserGroupItemStartDate")]
            [Validation(Required=false)]
            public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate CourserGroupItemStartDate { get; set; }
            public class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate : TeaModel {
                /// <summary>
                /// 一月的第几天
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// 一周的第几天
            /// </summary>
            [NameInMap("dayOfWeek")]
            [Validation(Required=false)]
            public int? DayOfWeek { get; set; }

            /// <summary>
            /// 课节
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public List<int?> SectionIndex { get; set; }

        }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// 合作方课程组code
        /// </summary>
        [NameInMap("isvCourseGroupCode")]
        [Validation(Required=false)]
        public string IsvCourseGroupCode { get; set; }

        /// <summary>
        /// 学段code
        /// </summary>
        [NameInMap("periodCode")]
        [Validation(Required=false)]
        public string PeriodCode { get; set; }

        /// <summary>
        /// 学年
        /// </summary>
        [NameInMap("schoolYear")]
        [Validation(Required=false)]
        public string SchoolYear { get; set; }

        /// <summary>
        /// 学期
        /// </summary>
        [NameInMap("semester")]
        [Validation(Required=false)]
        public int? Semester { get; set; }

        /// <summary>
        /// 学科
        /// </summary>
        [NameInMap("subjectName")]
        [Validation(Required=false)]
        public string SubjectName { get; set; }

        /// <summary>
        /// 教师信息
        /// </summary>
        [NameInMap("teacherInfos")]
        [Validation(Required=false)]
        public List<CreateUniversityCourseGroupRequestTeacherInfos> TeacherInfos { get; set; }
        public class CreateUniversityCourseGroupRequestTeacherInfos : TeaModel {
            /// <summary>
            /// 角色类型
            /// </summary>
            [NameInMap("participantRole")]
            [Validation(Required=false)]
            public string ParticipantRole { get; set; }

            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 操作人
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
