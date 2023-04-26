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
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }

                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }

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
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public long? Hour { get; set; }

                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                }

                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public long? SectionIndex { get; set; }

                [NameInMap("sectionName")]
                [Validation(Required=false)]
                public string SectionName { get; set; }

                [NameInMap("sectionType")]
                [Validation(Required=false)]
                public string SectionType { get; set; }

                [NameInMap("start")]
                [Validation(Required=false)]
                public QueryClassScheduleResponseBodyConfigSectionModelsStart Start { get; set; }
                public class QueryClassScheduleResponseBodyConfigSectionModelsStart : TeaModel {
                    [NameInMap("hour")]
                    [Validation(Required=false)]
                    public long? Hour { get; set; }

                    [NameInMap("min")]
                    [Validation(Required=false)]
                    public long? Min { get; set; }

                }

            }

            [NameInMap("start")]
            [Validation(Required=false)]
            public QueryClassScheduleResponseBodyConfigStart Start { get; set; }
            public class QueryClassScheduleResponseBodyConfigStart : TeaModel {
                [NameInMap("dayOfMonth")]
                [Validation(Required=false)]
                public long? DayOfMonth { get; set; }

                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }

                [NameInMap("year")]
                [Validation(Required=false)]
                public long? Year { get; set; }

            }

        }

        [NameInMap("courseDTOS")]
        [Validation(Required=false)]
        public List<QueryClassScheduleResponseBodyCourseDTOS> CourseDTOS { get; set; }
        public class QueryClassScheduleResponseBodyCourseDTOS : TeaModel {
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

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("creatorCorpId")]
            [Validation(Required=false)]
            public string CreatorCorpId { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

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

            [NameInMap("extInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }

            [NameInMap("introduce")]
            [Validation(Required=false)]
            public string Introduce { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("sectionIndex")]
            [Validation(Required=false)]
            public long? SectionIndex { get; set; }

            [NameInMap("sectionName")]
            [Validation(Required=false)]
            public string SectionName { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            [NameInMap("teacherCorpId")]
            [Validation(Required=false)]
            public string TeacherCorpId { get; set; }

            [NameInMap("teacherUserId")]
            [Validation(Required=false)]
            public string TeacherUserId { get; set; }

            [NameInMap("teacherUserName")]
            [Validation(Required=false)]
            public string TeacherUserName { get; set; }

        }

    }

}
