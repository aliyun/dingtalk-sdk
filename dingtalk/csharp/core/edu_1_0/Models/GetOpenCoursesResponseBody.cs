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
            /// <summary>
            /// 课程id
            /// </summary>
            [NameInMap("courseId")]
            [Validation(Required=false)]
            public string CourseId { get; set; }

            /// <summary>
            /// 封面图片地址
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// 课程类型: 0-直播 2-视频内容
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public long? FeedType { get; set; }

            /// <summary>
            /// 课程观看地址
            /// </summary>
            [NameInMap("jumpUrl")]
            [Validation(Required=false)]
            public string JumpUrl { get; set; }

            /// <summary>
            /// 课程开始时间
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 老师的userId
            /// </summary>
            [NameInMap("teacherId")]
            [Validation(Required=false)]
            public string TeacherId { get; set; }

            /// <summary>
            /// 老师名称
            /// </summary>
            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            /// <summary>
            /// 课程标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 总记录数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
