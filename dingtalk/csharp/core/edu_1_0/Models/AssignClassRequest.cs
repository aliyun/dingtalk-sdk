// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AssignClassRequest : TeaModel {
        [NameInMap("classId")]
        [Validation(Required=false)]
        public long? ClassId { get; set; }

        [NameInMap("isFinish")]
        [Validation(Required=false)]
        public bool? IsFinish { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("studentId")]
        [Validation(Required=false)]
        public long? StudentId { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
