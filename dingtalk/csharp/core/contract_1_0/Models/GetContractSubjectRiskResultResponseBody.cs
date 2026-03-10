// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class GetContractSubjectRiskResultResponseBody : TeaModel {
        [NameInMap("subjectRiskResponses")]
        [Validation(Required=false)]
        public List<GetContractSubjectRiskResultResponseBodySubjectRiskResponses> SubjectRiskResponses { get; set; }
        public class GetContractSubjectRiskResultResponseBodySubjectRiskResponses : TeaModel {
            [NameInMap("subjectBaseInfoResponse")]
            [Validation(Required=false)]
            public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse SubjectBaseInfoResponse { get; set; }
            public class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectBaseInfoResponse : TeaModel {
                [NameInMap("creditCode")]
                [Validation(Required=false)]
                public string CreditCode { get; set; }

                [NameInMap("establishTime")]
                [Validation(Required=false)]
                public long? EstablishTime { get; set; }

                [NameInMap("legalPersonName")]
                [Validation(Required=false)]
                public string LegalPersonName { get; set; }

                [NameInMap("regLocation")]
                [Validation(Required=false)]
                public string RegLocation { get; set; }

            }

            [NameInMap("subjectName")]
            [Validation(Required=false)]
            public string SubjectName { get; set; }

            [NameInMap("subjectRiskListResponse")]
            [Validation(Required=false)]
            public GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse SubjectRiskListResponse { get; set; }
            public class GetContractSubjectRiskResultResponseBodySubjectRiskResponsesSubjectRiskListResponse : TeaModel {
                [NameInMap("isSubjectExist")]
                [Validation(Required=false)]
                public bool? IsSubjectExist { get; set; }

                [NameInMap("riskTypes")]
                [Validation(Required=false)]
                public List<string> RiskTypes { get; set; }

                [NameInMap("risks")]
                [Validation(Required=false)]
                public Dictionary<string, object> Risks { get; set; }

                [NameInMap("totalRiskNumber")]
                [Validation(Required=false)]
                public int? TotalRiskNumber { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
