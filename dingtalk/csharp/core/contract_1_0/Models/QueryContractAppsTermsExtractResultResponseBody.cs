// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryContractAppsTermsExtractResultResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryContractAppsTermsExtractResultResponseBodyResult Result { get; set; }
        public class QueryContractAppsTermsExtractResultResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public QueryContractAppsTermsExtractResultResponseBodyResultData Data { get; set; }
            public class QueryContractAppsTermsExtractResultResponseBodyResultData : TeaModel {
                [NameInMap("extractedContents")]
                [Validation(Required=false)]
                public List<QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents> ExtractedContents { get; set; }
                public class QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContents : TeaModel {
                    [NameInMap("ruleCategory")]
                    [Validation(Required=false)]
                    public string RuleCategory { get; set; }

                    [NameInMap("termContents")]
                    [Validation(Required=false)]
                    public List<QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents> TermContents { get; set; }
                    public class QueryContractAppsTermsExtractResultResponseBodyResultDataExtractedContentsTermContents : TeaModel {
                        [NameInMap("detailTerm")]
                        [Validation(Required=false)]
                        public string DetailTerm { get; set; }

                        [NameInMap("exist")]
                        [Validation(Required=false)]
                        public string Exist { get; set; }

                        [NameInMap("shortTerm")]
                        [Validation(Required=false)]
                        public string ShortTerm { get; set; }

                        [NameInMap("termCategory")]
                        [Validation(Required=false)]
                        public string TermCategory { get; set; }

                    }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
