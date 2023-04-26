// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryClassScheduleByTimeSchoolResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryClassScheduleByTimeSchoolResponseBodyResult> Result { get; set; }
        public class QueryClassScheduleByTimeSchoolResponseBodyResult : TeaModel {
            [NameInMap("bizKey")]
            [Validation(Required=false)]
            public string BizKey { get; set; }

            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("classrooms")]
            [Validation(Required=false)]
            public List<QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms> Classrooms { get; set; }
            public class QueryClassScheduleByTimeSchoolResponseBodyResultClassrooms : TeaModel {
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
            public List<QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels> EduUserModels { get; set; }
            public class QueryClassScheduleByTimeSchoolResponseBodyResultEduUserModels : TeaModel {
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
