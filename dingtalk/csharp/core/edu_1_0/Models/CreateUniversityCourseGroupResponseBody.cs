// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateUniversityCourseGroupResponseBody : TeaModel {
        [NameInMap("courseGroupInfo")]
        [Validation(Required=false)]
        public CreateUniversityCourseGroupResponseBodyCourseGroupInfo CourseGroupInfo { get; set; }
        public class CreateUniversityCourseGroupResponseBodyCourseGroupInfo : TeaModel {
            [NameInMap("courseGroupCode")]
            [Validation(Required=false)]
            public string CourseGroupCode { get; set; }

        }

    }

}
