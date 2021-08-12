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
            /// 老师Staffid
            /// </summary>
            [NameInMap("teacherStaffIds")]
            [Validation(Required=false)]
            public List<string> TeacherStaffIds { get; set; }

            /// <summary>
            /// 课程名称
            /// </summary>
            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            /// <summary>
            /// 上课日期
            /// </summary>
            [NameInMap("dateModel")]
            [Validation(Required=false)]
            public UpdateCoursesOfClassRequestCoursesDateModel DateModel { get; set; }
            public class UpdateCoursesOfClassRequestCoursesDateModel : TeaModel {
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }
            };

            /// <summary>
            /// 节次模型
            /// </summary>
            [NameInMap("sectionModel")]
            [Validation(Required=false)]
            public UpdateCoursesOfClassRequestCoursesSectionModel SectionModel { get; set; }
            public class UpdateCoursesOfClassRequestCoursesSectionModel : TeaModel {
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }
            };

            /// <summary>
            /// 创建者名字
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// 上课地点
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// 删除标记：要删除为ture
            /// </summary>
            [NameInMap("deleteTag")]
            [Validation(Required=false)]
            public bool? DeleteTag { get; set; }

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

        }

        /// <summary>
        /// 节次设置
        /// </summary>
        [NameInMap("sectionConfig")]
        [Validation(Required=false)]
        public UpdateCoursesOfClassRequestSectionConfig SectionConfig { get; set; }
        public class UpdateCoursesOfClassRequestSectionConfig : TeaModel {
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<UpdateCoursesOfClassRequestSectionConfigSectionModels> SectionModels { get; set; }
            public class UpdateCoursesOfClassRequestSectionConfigSectionModels : TeaModel {
                public string SectionType { get; set; }
                public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart Start { get; set; }
                public class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart : TeaModel {
                    /// <summary>
                    /// 分钟
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    /// <summary>
                    /// 小时
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                }
                public int? SectionIndex { get; set; }
                public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd End { get; set; }
                public class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd : TeaModel {
                    /// <summary>
                    /// 分钟
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                    /// <summary>
                    /// 小时
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                }
            }
        };

        /// <summary>
        /// 操作者id
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
