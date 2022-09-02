// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class InitCoursesOfClassRequest : TeaModel {
        /// <summary>
        /// 课程设置。
        /// </summary>
        [NameInMap("courses")]
        [Validation(Required=false)]
        public List<InitCoursesOfClassRequestCourses> Courses { get; set; }
        public class InitCoursesOfClassRequestCourses : TeaModel {
            /// <summary>
            /// 课程名称。
            /// </summary>
            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            /// <summary>
            /// 创建者名称。
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// 上课时间。
            /// </summary>
            [NameInMap("dateModel")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestCoursesDateModel DateModel { get; set; }
            public class InitCoursesOfClassRequestCoursesDateModel : TeaModel {
                /// <summary>
                /// 每个月的第几天。
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月份。
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年份。
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// 上课地点
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// 课程节次。
            /// </summary>
            [NameInMap("sectionModel")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestCoursesSectionModel SectionModel { get; set; }
            public class InitCoursesOfClassRequestCoursesSectionModel : TeaModel {
                /// <summary>
                /// 节次序列号。
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// 节次名称。
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

            }

            /// <summary>
            /// 老师的staffId。
            /// </summary>
            [NameInMap("teacherStaffIds")]
            [Validation(Required=false)]
            public List<string> TeacherStaffIds { get; set; }

        }

        /// <summary>
        /// 节次设置
        /// </summary>
        [NameInMap("sectionConfig")]
        [Validation(Required=false)]
        public InitCoursesOfClassRequestSectionConfig SectionConfig { get; set; }
        public class InitCoursesOfClassRequestSectionConfig : TeaModel {
            /// <summary>
            /// 课程表结束开始时间（精确到日）
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestSectionConfigEnd End { get; set; }
            public class InitCoursesOfClassRequestSectionConfigEnd : TeaModel {
                /// <summary>
                /// 每个月的第几天。
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月份。
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年份。
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// 节次模型
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<InitCoursesOfClassRequestSectionConfigSectionModels> SectionModels { get; set; }
            public class InitCoursesOfClassRequestSectionConfigSectionModels : TeaModel {
                /// <summary>
                /// 结束时间
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public InitCoursesOfClassRequestSectionConfigSectionModelsEnd End { get; set; }
                public class InitCoursesOfClassRequestSectionConfigSectionModelsEnd : TeaModel {
                    /// <summary>
                    /// 小时
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// 分钟
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// 第几节。
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// 节次类型枚举：COURSE/REST
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                /// <summary>
                /// 开始时间
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public InitCoursesOfClassRequestSectionConfigSectionModelsStart Start { get; set; }
                public class InitCoursesOfClassRequestSectionConfigSectionModelsStart : TeaModel {
                    /// <summary>
                    /// 小时
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// 分钟
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

            }

            /// <summary>
            /// 课程表开始时间（精确到日）
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestSectionConfigStart Start { get; set; }
            public class InitCoursesOfClassRequestSectionConfigStart : TeaModel {
                /// <summary>
                /// 每个月的第几天。
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// 月份。
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// 年份。
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

        /// <summary>
        /// 操作人的userid。
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
