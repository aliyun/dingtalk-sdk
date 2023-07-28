// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetTaskStudentListResponseBody : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("studentList")]
        [Validation(Required=false)]
        public List<GetTaskStudentListResponseBodyStudentList> StudentList { get; set; }
        public class GetTaskStudentListResponseBodyStudentList : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("sexuality")]
            [Validation(Required=false)]
            public string Sexuality { get; set; }

            [NameInMap("studentId")]
            [Validation(Required=false)]
            public long? StudentId { get; set; }

        }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
