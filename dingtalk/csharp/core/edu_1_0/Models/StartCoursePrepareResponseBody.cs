// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class StartCoursePrepareResponseBody : TeaModel {
        [NameInMap("universityCourseCommonResponse")]
        [Validation(Required=false)]
        public StartCoursePrepareResponseBodyUniversityCourseCommonResponse UniversityCourseCommonResponse { get; set; }
        public class StartCoursePrepareResponseBodyUniversityCourseCommonResponse : TeaModel {
            [NameInMap("courseCode")]
            [Validation(Required=false)]
            public string CourseCode { get; set; }

            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
