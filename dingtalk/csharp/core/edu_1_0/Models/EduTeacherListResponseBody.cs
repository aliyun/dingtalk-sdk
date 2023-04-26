// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class EduTeacherListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EduTeacherListResponseBodyResult Result { get; set; }
        public class EduTeacherListResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("teacherDetails")]
            [Validation(Required=false)]
            public List<EduTeacherListResponseBodyResultTeacherDetails> TeacherDetails { get; set; }
            public class EduTeacherListResponseBodyResultTeacherDetails : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

    }

}
