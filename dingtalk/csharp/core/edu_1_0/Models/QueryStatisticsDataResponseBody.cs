// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryStatisticsDataResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryStatisticsDataResponseBodyResult> Result { get; set; }
        public class QueryStatisticsDataResponseBodyResult : TeaModel {
            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// 用户名称
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// 班级id
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// 学科名称
            /// </summary>
            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public long? SubjectName { get; set; }

            /// <summary>
            /// 总学时
            /// </summary>
            [NameInMap("courseHours")]
            [Validation(Required=false)]
            public float? CourseHours { get; set; }

            /// <summary>
            /// 总课程数
            /// </summary>
            [NameInMap("courseCount")]
            [Validation(Required=false)]
            public long? CourseCount { get; set; }

        }

    }

}
