// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateEvaluatePerformanceCountRequest : TeaModel {
        [NameInMap("teacherId")]
        [Validation(Required=false)]
        public string TeacherId { get; set; }

        [NameInMap("unreadData")]
        [Validation(Required=false)]
        public List<UpdateEvaluatePerformanceCountRequestUnreadData> UnreadData { get; set; }
        public class UpdateEvaluatePerformanceCountRequestUnreadData : TeaModel {
            [NameInMap("number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            [NameInMap("studentId")]
            [Validation(Required=false)]
            public string StudentId { get; set; }

        }

    }

}
