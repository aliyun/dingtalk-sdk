// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateCoursesOfClassRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courses")]
        [Validation(Required=false)]
        public List<UpdateCoursesOfClassRequestCourses> Courses { get; set; }
        public class UpdateCoursesOfClassRequestCourses : TeaModel {
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("dateModel")]
            [Validation(Required=false)]
            public UpdateCoursesOfClassRequestCoursesDateModel DateModel { get; set; }
            public class UpdateCoursesOfClassRequestCoursesDateModel : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            [NameInMap("deleteTag")]
            [Validation(Required=false)]
            public bool? DeleteTag { get; set; }

            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sectionModel")]
            [Validation(Required=false)]
            public UpdateCoursesOfClassRequestCoursesSectionModel SectionModel { get; set; }
            public class UpdateCoursesOfClassRequestCoursesSectionModel : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

            }

            [NameInMap("teacherStaffIds")]
            [Validation(Required=false)]
            public List<string> TeacherStaffIds { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("sectionConfig")]
        [Validation(Required=false)]
        public UpdateCoursesOfClassRequestSectionConfig SectionConfig { get; set; }
        public class UpdateCoursesOfClassRequestSectionConfig : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<UpdateCoursesOfClassRequestSectionConfigSectionModels> SectionModels { get; set; }
            public class UpdateCoursesOfClassRequestSectionConfigSectionModels : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd End { get; set; }
                public class UpdateCoursesOfClassRequestSectionConfigSectionModelsEnd : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public UpdateCoursesOfClassRequestSectionConfigSectionModelsStart Start { get; set; }
                public class UpdateCoursesOfClassRequestSectionConfigSectionModelsStart : TeaModel {
                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
