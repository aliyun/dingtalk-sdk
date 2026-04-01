// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetAsyncCreateContractAnalysisResponseBody : TeaModel {
        [NameInMap("analysisStatus")]
        [Validation(Required=false)]
        public string AnalysisStatus { get; set; }

        [NameInMap("companyList")]
        [Validation(Required=false)]
        public List<string> CompanyList { get; set; }

        [NameInMap("reviewPositions")]
        [Validation(Required=false)]
        public List<string> ReviewPositions { get; set; }

        [NameInMap("reviewType")]
        [Validation(Required=false)]
        public string ReviewType { get; set; }

        [NameInMap("wordCount")]
        [Validation(Required=false)]
        public int? WordCount { get; set; }

    }

}
