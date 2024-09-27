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
            /// <summary>
            /// <b>Example:</b>
            /// <para>3333333</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingding142523424</para>
            /// </summary>
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>kindergarten</para>
            /// </summary>
            [NameInMap("periodCode")]
            [Validation(Required=false)]
            public string PeriodCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn_yuwen</para>
            /// </summary>
            [NameInMap("subjectCode")]
            [Validation(Required=false)]
            public string SubjectCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>语文</para>
            /// </summary>
            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李老师</para>
            /// </summary>
            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50142345134</para>
            /// </summary>
            [NameInMap("teacherUserId")]
            [Validation(Required=false)]
            public string TeacherUserId { get; set; }

        }

    }

}
