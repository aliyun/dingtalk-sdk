// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetOpenCoursesResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courseList")]
        [Validation(Required=false)]
        public List<GetOpenCoursesResponseBodyCourseList> CourseList { get; set; }
        public class GetOpenCoursesResponseBodyCourseList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("courseId")]
            [Validation(Required=false)]
            public string CourseId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public long? FeedType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("jumpUrl")]
            [Validation(Required=false)]
            public string JumpUrl { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("teacherId")]
            [Validation(Required=false)]
            public string TeacherId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
