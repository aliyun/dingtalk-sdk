// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EduListUserByFromUserIdsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<EduListUserByFromUserIdsResponseBodyResult> Result { get; set; }
        public class EduListUserByFromUserIdsResponseBodyResult : TeaModel {
            [NameInMap("campusId")]
            [Validation(Required=false)]
            public long? CampusId { get; set; }

            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("gradeId")]
            [Validation(Required=false)]
            public long? GradeId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("periodId")]
            [Validation(Required=false)]
            public long? PeriodId { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
