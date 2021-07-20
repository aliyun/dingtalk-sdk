// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryTeachSubjectsResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryTeachSubjectsResponseBodyResult> Result { get; set; }
        public class QueryTeachSubjectsResponseBodyResult : TeaModel {
            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            [NameInMap("orgId")]
            [Validation(Required=false)]
            public long? OrgId { get; set; }

            [NameInMap("teacherUid")]
            [Validation(Required=false)]
            public long? TeacherUid { get; set; }

            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

        }

    }

}
