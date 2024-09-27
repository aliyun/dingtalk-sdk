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
            /// <summary>
            /// <b>Example:</b>
            /// <para>2345</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("courseCount")]
            [Validation(Required=false)]
            public long? CourseCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("courseHours")]
            [Validation(Required=false)]
            public float? CourseHours { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn_shuxue</para>
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
            public long? SubjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2352345345</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>李老师</para>
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
