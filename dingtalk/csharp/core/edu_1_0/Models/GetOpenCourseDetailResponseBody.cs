// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetOpenCourseDetailResponseBody : TeaModel {
        [NameInMap("courseId")]
        [Validation(Required=false)]
        public string CourseId { get; set; }

        [NameInMap("courseType")]
        [Validation(Required=false)]
        public long? CourseType { get; set; }

        [NameInMap("coverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        [NameInMap("introduction")]
        [Validation(Required=false)]
        public string Introduction { get; set; }

        [NameInMap("pushModel")]
        [Validation(Required=false)]
        public GetOpenCourseDetailResponseBodyPushModel PushModel { get; set; }
        public class GetOpenCourseDetailResponseBodyPushModel : TeaModel {
            [NameInMap("pushOrgNameList")]
            [Validation(Required=false)]
            public List<string> PushOrgNameList { get; set; }

            [NameInMap("pushRoleNameList")]
            [Validation(Required=false)]
            public List<string> PushRoleNameList { get; set; }

        }

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

}
