// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QuerySelfBuildGroupBaseInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QuerySelfBuildGroupBaseInfoResponseBodyResult Result { get; set; }
        public class QuerySelfBuildGroupBaseInfoResponseBodyResult : TeaModel {
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("className")]
            [Validation(Required=false)]
            public string ClassName { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("gradeLevel")]
            [Validation(Required=false)]
            public int? GradeLevel { get; set; }

            [NameInMap("groupType")]
            [Validation(Required=false)]
            public string GroupType { get; set; }

            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
