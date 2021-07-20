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
            /// teacherStaffIds
            /// </summary>
            [NameInMap("teacherStaffIds")]
            [Validation(Required=false)]
            public List<string> TeacherStaffIds { get; set; }

            /// <summary>
            /// courseName
            /// </summary>
            [NameInMap("courseName")]
            [Validation(Required=false)]
            public string CourseName { get; set; }

            /// <summary>
            /// dateModel
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
            /// sectionModel
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
            /// creatorName
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// location
            /// </summary>
            [NameInMap("location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            /// <summary>
            /// deleteTag
            /// </summary>
            [NameInMap("deleteTag")]
            [Validation(Required=false)]
            public bool? DeleteTag { get; set; }

            /// <summary>
            /// courseCode
            /// </summary>
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

        }

        /// <summary>
        /// opUserId
        /// </summary>
        [NameInMap("opUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

    }

}
