// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateCoursesOfClassRequest : TeaModel {
        [NameInMap("courses")]
        [Validation(Required=false)]
        public List<UpdateCoursesOfClassRequestCourses> Courses { get; set; }
        public class UpdateCoursesOfClassRequestCourses : TeaModel {
            /// <summary>
            /// 课程code：删除/更新必填
            /// </summary>
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            /// <summary>
            /// 课组code
            /// </summary>
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

            /// <summary>
            /// 课程名称
            /// </summary>
            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            /// <summary>
            /// 创建者名字
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// 上课日期
            /// </summary>
            [NameInMap("dateModel")]
            [Validation(Required=false)]
            public UpdateCoursesOfClassRequestCoursesDateModel DateModel { get; set; }
            public class UpdateCoursesOfClassRequestCoursesDateModel : TeaModel {
                /// <summary>
                /// dayOfMonth
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// month
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// year
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// 删除标记：要删除为ture
            /// </summary>
            [NameInMap("deleteTag")]
            [Validation(Required=false)]
            public bool? DeleteTag { get; set; }

            /// <summary>
            /// 上课地点
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// 节次模型
            /// </summary>
            [NameInMap("sectionModel")]
            [Validation(Required=false)]
            public UpdateCoursesOfClassRequestCoursesSectionModel SectionModel { get; set; }
            public class UpdateCoursesOfClassRequestCoursesSectionModel : TeaModel {
                /// <summary>
                /// 节次index
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// 节次名称
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                /// <summary>
                /// sectionType
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

            }

            /// <summary>
            /// 老师Staffid
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
        public UpdateCoursesOfClassRequestSectionConfig SectionConfig { get; set; }
        public class UpdateCoursesOfClassRequestSectionConfig : TeaModel {
            /// <summary>
            /// 节次模型
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<UpdateCoursesOfClassRequestSectionConfigSectionModels> SectionModels { get; set; }
            public class UpdateCoursesOfClassRequestSectionConfigSectionModels : TeaModel {
                /// <summary>
                /// 结束时间
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd End { get; set; }
                public class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd : TeaModel {
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
                public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart Start { get; set; }
                public class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart : TeaModel {
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

        }

        /// <summary>
        /// 操作者id
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
