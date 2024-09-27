// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class InitCoursesOfClassRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("courses")]
        [Validation(Required=false)]
        public List<InitCoursesOfClassRequestCourses> Courses { get; set; }
        public class InitCoursesOfClassRequestCourses : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>语文</para>
            /// </summary>
            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李老师</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("dateModel")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestCoursesDateModel DateModel { get; set; }
            public class InitCoursesOfClassRequestCoursesDateModel : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>正心楼1-1</para>
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sectionModel")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestCoursesSectionModel SectionModel { get; set; }
            public class InitCoursesOfClassRequestCoursesSectionModel : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>第一节</para>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sectionConfig")]
        [Validation(Required=false)]
        public InitCoursesOfClassRequestSectionConfig SectionConfig { get; set; }
        public class InitCoursesOfClassRequestSectionConfig : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestSectionConfigEnd End { get; set; }
            public class InitCoursesOfClassRequestSectionConfigEnd : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<InitCoursesOfClassRequestSectionConfigSectionModels> SectionModels { get; set; }
            public class InitCoursesOfClassRequestSectionConfigSectionModels : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("end")]
                [Validation(Required=false)]
                public InitCoursesOfClassRequestSectionConfigSectionModelsEnd End { get; set; }
                public class InitCoursesOfClassRequestSectionConfigSectionModelsEnd : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>45</para>
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public int? SectionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>COURSE：上课节次 REST：休息节次</para>
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("start")]
                [Validation(Required=false)]
                public InitCoursesOfClassRequestSectionConfigSectionModelsStart Start { get; set; }
                public class InitCoursesOfClassRequestSectionConfigSectionModelsStart : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public int? Hour { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public int? Min { get; set; }

                }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public InitCoursesOfClassRequestSectionConfigStart Start { get; set; }
            public class InitCoursesOfClassRequestSectionConfigStart : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public int? DayOfMonth { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public int? Month { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public int? Year { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>manager235</para>
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
