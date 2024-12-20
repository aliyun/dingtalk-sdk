// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkteam_sphere_1_0.Models
{
    public class AnalysisReportRequest : TeaModel {
        [NameInMap("filter")]
        [Validation(Required=false)]
        public AnalysisReportRequestFilter Filter { get; set; }
        public class AnalysisReportRequestFilter : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

        }

        [NameInMap("reportId")]
        [Validation(Required=false)]
        public string ReportId { get; set; }

    }

}
