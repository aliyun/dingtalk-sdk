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
            /// <summary>
            /// <b>Example:</b>
            /// <para>666666</para>
            /// </summary>
            [NameInMap("campusId")]
            [Validation(Required=false)]
            public long? CampusId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("classId")]
            [Validation(Required=false)]
            public long? ClassId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>555555</para>
            /// </summary>
            [NameInMap("gradeId")]
            [Validation(Required=false)]
            public long? GradeId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>叔大</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>444444</para>
            /// </summary>
            [NameInMap("periodId")]
            [Validation(Required=false)]
            public long? PeriodId { get; set; }

            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
