// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryUniversityCourseGroupResponseBody : TeaModel {
        [NameInMap("universityCourseGroupInfo")]
        [Validation(Required=false)]
        public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo UniversityCourseGroupInfo { get; set; }
        public class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfo : TeaModel {
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

            [NameInMap("courseGroupIntroduce")]
            [Validation(Required=false)]
            public string CourseGroupIntroduce { get; set; }

            [NameInMap("courseGroupName")]
            [Validation(Required=false)]
            public string CourseGroupName { get; set; }

            [NameInMap("courserGroupItemModels")]
            [Validation(Required=false)]
            public List<QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels> CourserGroupItemModels { get; set; }
            public class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModels : TeaModel {
                [NameInMap("classPeriodType")]
                [Validation(Required=false)]
                public int? ClassPeriodType { get; set; }

                [NameInMap("classroomId")]
                [Validation(Required=false)]
                public long? ClassroomId { get; set; }

                [NameInMap("courseType")]
                [Validation(Required=false)]
                public int? CourseType { get; set; }

                [NameInMap("courserGroupItemEndDate")]
                [Validation(Required=false)]
                public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate CourserGroupItemEndDate { get; set; }
                public class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemEndDate : TeaModel {
                    [NameInMap("dayOfMonth")]
                    [Validation(Required=false)]
                    public int? DayOfMonth { get; set; }

                    [NameInMap("month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    [NameInMap("year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                [NameInMap("courserGroupItemStartDate")]
                [Validation(Required=false)]
                public QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate CourserGroupItemStartDate { get; set; }
                public class QueryUniversityCourseGroupResponseBodyUniversityCourseGroupInfoCourserGroupItemModelsCourserGroupItemStartDate : TeaModel {
                    [NameInMap("dayOfMonth")]
                    [Validation(Required=false)]
                    public int? DayOfMonth { get; set; }

                    [NameInMap("month")]
                    [Validation(Required=false)]
                    public int? Month { get; set; }

                    [NameInMap("year")]
                    [Validation(Required=false)]
                    public int? Year { get; set; }

                }

                [NameInMap("dayOfWeek")]
                [Validation(Required=false)]
                public int? DayOfWeek { get; set; }

                [NameInMap("sectionIndex")]
                [Validation(Required=false)]
                public List<int?> SectionIndex { get; set; }

            }

            [NameInMap("isvCourseGroupCode")]
            [Validation(Required=false)]
            public string IsvCourseGroupCode { get; set; }

            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            [NameInMap("schoolYear")]
            [Validation(Required=false)]
            public string SchoolYear { get; set; }

            [NameInMap("semester")]
            [Validation(Required=false)]
            public int? Semester { get; set; }

            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

        }

    }

}
