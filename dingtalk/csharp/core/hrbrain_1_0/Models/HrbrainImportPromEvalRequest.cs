// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainImportPromEvalRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<HrbrainImportPromEvalRequestBody> Body { get; set; }
        public class HrbrainImportPromEvalRequestBody : TeaModel {
            [NameInMap("comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("effectiveDate")]
            [Validation(Required=false)]
            public string EffectiveDate { get; set; }

            [NameInMap("extendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ExtendInfo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("newJobLevel")]
            [Validation(Required=false)]
            public string NewJobLevel { get; set; }

            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            [NameInMap("periodEndDate")]
            [Validation(Required=false)]
            public string PeriodEndDate { get; set; }

            [NameInMap("periodStartDate")]
            [Validation(Required=false)]
            public string PeriodStartDate { get; set; }

            [NameInMap("preJobLevel")]
            [Validation(Required=false)]
            public string PreJobLevel { get; set; }

            [NameInMap("workNo")]
            [Validation(Required=false)]
            public string WorkNo { get; set; }

        }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

    }

}
