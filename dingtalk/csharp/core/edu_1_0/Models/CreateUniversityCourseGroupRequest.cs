// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateUniversityCourseGroupRequest : TeaModel {
        [NameInMap("courseGroupIntroduce")]
        [Validation(Required=false)]
        public string CourseGroupIntroduce { get; set; }

        [NameInMap("courseGroupName")]
        [Validation(Required=false)]
        public string CourseGroupName { get; set; }

        [NameInMap("courserGroupItemModels")]
        [Validation(Required=false)]
        public List<CreateUniversityCourseGroupRequestCourserGroupItemModels> CourserGroupItemModels { get; set; }
        public class CreateUniversityCourseGroupRequestCourserGroupItemModels : TeaModel {
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
            public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate CourserGroupItemEndDate { get; set; }
            public class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemEndDate : TeaModel {
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
            public CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate CourserGroupItemStartDate { get; set; }
            public class CreateUniversityCourseGroupRequestCourserGroupItemModelsCourserGroupItemStartDate : TeaModel {
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

        [NameInMap("ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

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

        [NameInMap("teacherInfos")]
        [Validation(Required=false)]
        public List<CreateUniversityCourseGroupRequestTeacherInfos> TeacherInfos { get; set; }
        public class CreateUniversityCourseGroupRequestTeacherInfos : TeaModel {
            [NameInMap("participantRole")]
            [Validation(Required=false)]
            public string ParticipantRole { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
