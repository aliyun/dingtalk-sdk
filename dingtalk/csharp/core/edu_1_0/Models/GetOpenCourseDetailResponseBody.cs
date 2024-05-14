// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetOpenCourseDetailResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courseId")]
        [Validation(Required=false)]
        public string CourseId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("courseType")]
        [Validation(Required=false)]
        public long? CourseType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pushModel")]
        [Validation(Required=false)]
        public GetOpenCourseDetailResponseBodyPushModel PushModel { get; set; }
        public class GetOpenCourseDetailResponseBodyPushModel : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("pushOrgNameList")]
            [Validation(Required=false)]
            public List<string> PushOrgNameList { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("pushRoleNameList")]
            [Validation(Required=false)]
            public List<string> PushRoleNameList { get; set; }

        }

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

}
