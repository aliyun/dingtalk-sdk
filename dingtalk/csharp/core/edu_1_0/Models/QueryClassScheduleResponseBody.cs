// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleResponseBody : TeaModel {
        [NameInMap("config")]
        [Validation(Required=false)]
        public QueryClassScheduleResponseBodyConfig Config { get; set; }
        public class QueryClassScheduleResponseBodyConfig : TeaModel {
            [NameInMap("end")]
            [Validation(Required=false)]
            public QueryClassScheduleResponseBodyConfigEnd End { get; set; }
            public class QueryClassScheduleResponseBodyConfigEnd : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public long? Year { get; set; }

            }

            [NameInMap("sectionModels")]
            [Validation(Required=false)]
            public List<QueryClassScheduleResponseBodyConfigSectionModels> SectionModels { get; set; }
            public class QueryClassScheduleResponseBodyConfigSectionModels : TeaModel {
                [NameInMap("end")]
                [Validation(Required=false)]
                public QueryClassScheduleResponseBodyConfigSectionModelsEnd End { get; set; }
                public class QueryClassScheduleResponseBodyConfigSectionModelsEnd : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public long? Hour { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>45</para>
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public long? SectionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>第一节</para>
                /// </summary>
                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>COURSE</para>
                /// </summary>
                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public QueryClassScheduleResponseBodyConfigSectionModelsStart Start { get; set; }
                public class QueryClassScheduleResponseBodyConfigSectionModelsStart : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public long? Hour { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                }

            }

            [NameInMap("start")]
            [Validation(Required=false)]
            public QueryClassScheduleResponseBodyConfigStart Start { get; set; }
            public class QueryClassScheduleResponseBodyConfigStart : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020</para>
                /// </summary>
                [NameInMap("year")]
                [Validation(Required=false)]
                public long? Year { get; set; }

            }

        }

        [NameInMap("courseDTOS")]
        [Validation(Required=false)]
        public List<QueryClassScheduleResponseBodyCourseDTOS> CourseDTOS { get; set; }
        public class QueryClassScheduleResponseBodyCourseDTOS : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2345</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("classrooms")]
            [Validation(Required=false)]
            public List<QueryClassScheduleResponseBodyCourseDTOSClassrooms> Classrooms { get; set; }
            public class QueryClassScheduleResponseBodyCourseDTOSClassrooms : TeaModel {
                [NameInMap("interactInfo")]
                [Validation(Required=false)]
                public string InteractInfo { get; set; }

                [NameInMap("targetId")]
                [Validation(Required=false)]
                public string TargetId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn_yuwen</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ekk24352534</para>
            /// </summary>
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ruu</para>
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding32534536235</para>
            /// </summary>
            [NameInMap("creatorCorpId")]
            [Validation(Required=false)]
            public string CreatorCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>234525235</para>
            /// </summary>
            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>行政老师A</para>
            /// </summary>
            [NameInMap("creatorUserName")]
            [Validation(Required=false)]
            public string CreatorUserName { get; set; }

            [NameInMap("eduUserModels")]
            [Validation(Required=false)]
            public List<QueryClassScheduleResponseBodyCourseDTOSEduUserModels> EduUserModels { get; set; }
            public class QueryClassScheduleResponseBodyCourseDTOSEduUserModels : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public long? Uid { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("endTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ext</para>
            /// </summary>
            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>这是语文</para>
            /// </summary>
            [NameInMap("introduce")]
            [Validation(Required=false)]
            public string Introduce { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>语文</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public long? SectionIndex { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>语文</para>
            /// </summary>
            [NameInMap("sectionName")]
            [Validation(Required=false)]
            public string SectionName { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn_yuwen</para>
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ding32534536235</para>
            /// </summary>
            [NameInMap("teacherCorpId")]
            [Validation(Required=false)]
            public string TeacherCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25354252543</para>
            /// </summary>
            [NameInMap("teacherUserId")]
            [Validation(Required=false)]
            public string TeacherUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李老师</para>
            /// </summary>
            [NameInMap("teacherUserName")]
            [Validation(Required=false)]
            public string TeacherUserName { get; set; }

        }

    }

}
