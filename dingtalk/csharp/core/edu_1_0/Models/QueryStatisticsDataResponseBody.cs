// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryStatisticsDataResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryStatisticsDataResponseBodyResult> Result { get; set; }
        public class QueryStatisticsDataResponseBodyResult : TeaModel {
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("courseCount")]
            [Validation(Required=false)]
            public long? CourseCount { get; set; }

            [NameInMap("courseHours")]
            [Validation(Required=false)]
            public float? CourseHours { get; set; }

            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public long? SubjectName { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
