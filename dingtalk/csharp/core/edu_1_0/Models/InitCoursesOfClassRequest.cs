// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class InitCoursesOfClassRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courses")]
        [Validation(Required=false)]
        public List<InitCoursesOfClassRequestCourses> Courses { get; set; }
        public class InitCoursesOfClassRequestCourses : TeaModel {
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
            public InitCoursesOfClassRequestCoursesDateModel DateModel { get; set; }
            public class InitCoursesOfClassRequestCoursesDateModel : TeaModel {
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

            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sectionModel")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestCoursesSectionModel SectionModel { get; set; }
            public class InitCoursesOfClassRequestCoursesSectionModel : TeaModel {
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
        public InitCoursesOfClassRequestSectionConfig SectionConfig { get; set; }
        public class InitCoursesOfClassRequestSectionConfig : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestSectionConfigEnd End { get; set; }
            public class InitCoursesOfClassRequestSectionConfigEnd : TeaModel {
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<InitCoursesOfClassRequestSectionConfigSectionModels> SectionModels { get; set; }
            public class InitCoursesOfClassRequestSectionConfigSectionModels : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public InitCoursesOfClassRequestSectionConfigSectionModelsEnd End { get; set; }
                public class InitCoursesOfClassRequestSectionConfigSectionModelsEnd : TeaModel {
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
                public InitCoursesOfClassRequestSectionConfigSectionModelsStart Start { get; set; }
                public class InitCoursesOfClassRequestSectionConfigSectionModelsStart : TeaModel {
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

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestSectionConfigStart Start { get; set; }
            public class InitCoursesOfClassRequestSectionConfigStart : TeaModel {
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

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
