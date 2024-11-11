// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryTeacherCourseResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryTeacherCourseResponseBodyResult Result { get; set; }
        public class QueryTeacherCourseResponseBodyResult : TeaModel {
            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("isvCode")]
            [Validation(Required=false)]
            public string IsvCode { get; set; }

            [NameInMap("teacherCourseDetailItemList")]
            [Validation(Required=false)]
            public List<QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList> TeacherCourseDetailItemList { get; set; }
            public class QueryTeacherCourseResponseBodyResultTeacherCourseDetailItemList : TeaModel {
                [NameInMap("attributes")]
                [Validation(Required=false)]
                public string Attributes { get; set; }

                [NameInMap("isvCourseId")]
                [Validation(Required=false)]
                public string IsvCourseId { get; set; }

            }

            [NameInMap("teacherName")]
            [Validation(Required=false)]
            public string TeacherName { get; set; }

            [NameInMap("teacherUserId")]
            [Validation(Required=false)]
            public string TeacherUserId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
