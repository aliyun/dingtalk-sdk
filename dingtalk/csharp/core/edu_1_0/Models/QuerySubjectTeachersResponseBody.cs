// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QuerySubjectTeachersResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QuerySubjectTeachersResponseBodyResult> Result { get; set; }
        public class QuerySubjectTeachersResponseBodyResult : TeaModel {
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            [NameInMap("teacherUserId")]
            [Validation(Required=false)]
            public string TeacherUserId { get; set; }

        }

    }

}
