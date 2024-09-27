// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetOpenCoursesResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("courseList")]
        [Validation(Required=false)]
        public List<GetOpenCoursesResponseBodyCourseList> CourseList { get; set; }
        public class GetOpenCoursesResponseBodyCourseList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fdjakl-fdaf-ds</para>
            /// </summary>
            [NameInMap("courseId")]
            [Validation(Required=false)]
            public string CourseId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://static.dingtalk.com/media/lALPDgCwRt4FagzMi8yZ_153_139.png">https://static.dingtalk.com/media/lALPDgCwRt4FagzMi8yZ_153_139.png</a></para>
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("feedType")]
            [Validation(Required=false)]
            public long? FeedType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://h5.dingtalk.com/live/video_lesson.htm?feedId=4aa5ter-05d8-4aac-834a-3b3847cf642e&mcnId=7536041420201104593&feedProperty=1&itemId=4aa563e1-05d8-4aac-841a-3b3847cf642e&dd_nav_bgcolor=FF2C2D2F#/live">https://h5.dingtalk.com/live/video_lesson.htm?feedId=4aa5ter-05d8-4aac-834a-3b3847cf642e&amp;mcnId=7536041420201104593&amp;feedProperty=1&amp;itemId=4aa563e1-05d8-4aac-841a-3b3847cf642e&amp;dd_nav_bgcolor=FF2C2D2F#/live</a></para>
            /// </summary>
            [NameInMap("jumpUrl")]
            [Validation(Required=false)]
            public string JumpUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1618369786000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123124312314</para>
            /// </summary>
            [NameInMap("teacherId")]
            [Validation(Required=false)]
            public string TeacherId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张老师</para>
            /// </summary>
            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>开学第一课</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
