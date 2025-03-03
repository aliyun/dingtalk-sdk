// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddEvaluatePerformanceRequest : TeaModel {
        [NameInMap("evaluationData")]
        [Validation(Required=false)]
        public List<AddEvaluatePerformanceRequestEvaluationData> EvaluationData { get; set; }
        public class AddEvaluatePerformanceRequestEvaluationData : TeaModel {
            [NameInMap("evaluationContent")]
            [Validation(Required=false)]
            public string EvaluationContent { get; set; }

            [NameInMap("eventTime")]
            [Validation(Required=false)]
            public string EventTime { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("studentId")]
            [Validation(Required=false)]
            public string StudentId { get; set; }

            [NameInMap("teacherId")]
            [Validation(Required=false)]
            public string TeacherId { get; set; }

        }

    }

}
