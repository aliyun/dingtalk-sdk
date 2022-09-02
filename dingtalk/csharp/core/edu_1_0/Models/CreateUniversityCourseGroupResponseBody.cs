// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateUniversityCourseGroupResponseBody : TeaModel {
        /// <summary>
        /// 课程组信息
        /// </summary>
        [NameInMap("courseGroupInfo")]
        [Validation(Required=false)]
        public CreateUniversityCourseGroupResponseBodyCourseGroupInfo CourseGroupInfo { get; set; }
        public class CreateUniversityCourseGroupResponseBodyCourseGroupInfo : TeaModel {
            /// <summary>
            /// 课程组编码
            /// </summary>
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

        }

    }

}
