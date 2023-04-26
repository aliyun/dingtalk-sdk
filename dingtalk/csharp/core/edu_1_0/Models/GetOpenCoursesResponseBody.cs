// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetOpenCoursesResponseBody : TeaModel {
        [NameInMap("courseList")]
        [Validation(Required=false)]
        public List<GetOpenCoursesResponseBodyCourseList> CourseList { get; set; }
        public class GetOpenCoursesResponseBodyCourseList : TeaModel {
            [NameInMap("courseId")]
            [Validation(Required=false)]
            public string CourseId { get; set; }

            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("feedType")]
            [Validation(Required=false)]
            public long? FeedType { get; set; }

            [NameInMap("jumpUrl")]
            [Validation(Required=false)]
            public string JumpUrl { get; set; }

            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("teacherId")]
            [Validation(Required=false)]
            public string TeacherId { get; set; }

            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
