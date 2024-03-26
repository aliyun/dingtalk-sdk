// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportPerfEvalRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportPerfEvalRequestBody> Body { get; set; }
        public class HrbrainImportPerfEvalRequestBody : TeaModel {
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("perfCate")]
            [Validation(Required=false)]
            public string PerfCate { get; set; }

            [NameInMap("perfPlanName")]
            [Validation(Required=false)]
            public string PerfPlanName { get; set; }

            [NameInMap("perfScore")]
            [Validation(Required=false)]
            public string PerfScore { get; set; }

            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            [NameInMap("periodEndDate")]
            [Validation(Required=false)]
            public string PeriodEndDate { get; set; }

            [NameInMap("periodStartDate")]
            [Validation(Required=false)]
            public string PeriodStartDate { get; set; }

            [NameInMap("score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
