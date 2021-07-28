// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QuerySubjectTeachersResponseBody : TeaModel {
        /// <summary>
        /// 结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QuerySubjectTeachersResponseBodyResult> Result { get; set; }
        public class QuerySubjectTeachersResponseBodyResult : TeaModel {
            /// <summary>
            /// 老师名称
            /// </summary>
            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            /// <summary>
            /// 学科名称
            /// </summary>
            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            /// <summary>
            /// 学科code
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            /// <summary>
            /// 学段code
            /// </summary>
            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            /// <summary>
            /// 组织id
            /// </summary>
            [NameInMap("orgId")]
            [Validation(Required=false)]
            public long? OrgId { get; set; }

            /// <summary>
            /// 老师Uid
            /// </summary>
            [NameInMap("teacherUid")]
            [Validation(Required=false)]
            public long? TeacherUid { get; set; }

            /// <summary>
            /// 班级id
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

        }

    }

}
