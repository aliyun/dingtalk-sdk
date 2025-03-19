// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryContractAppsCompareResultResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryContractAppsCompareResultResponseBodyResult Result { get; set; }
        public class QueryContractAppsCompareResultResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public QueryContractAppsCompareResultResponseBodyResultData Data { get; set; }
            public class QueryContractAppsCompareResultResponseBodyResultData : TeaModel {
                [NameInMap("compareDetail")]
                [Validation(Required=false)]
                public QueryContractAppsCompareResultResponseBodyResultDataCompareDetail CompareDetail { get; set; }
                public class QueryContractAppsCompareResultResponseBodyResultDataCompareDetail : TeaModel {
                    [NameInMap("details")]
                    [Validation(Required=false)]
                    public List<QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails> Details { get; set; }
                    public class QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDetails : TeaModel {
                        [NameInMap("compareWords")]
                        [Validation(Required=false)]
                        public string CompareWords { get; set; }

                        [NameInMap("originalWords")]
                        [Validation(Required=false)]
                        public string OriginalWords { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    [NameInMap("differenceCount")]
                    [Validation(Required=false)]
                    public QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount DifferenceCount { get; set; }
                    public class QueryContractAppsCompareResultResponseBodyResultDataCompareDetailDifferenceCount : TeaModel {
                        [NameInMap("add")]
                        [Validation(Required=false)]
                        public int? Add { get; set; }

                        [NameInMap("delete")]
                        [Validation(Required=false)]
                        public int? Delete { get; set; }

                        [NameInMap("replace")]
                        [Validation(Required=false)]
                        public int? Replace { get; set; }

                        [NameInMap("total")]
                        [Validation(Required=false)]
                        public int? Total { get; set; }

                    }

                }

                [NameInMap("compareDetailUrl")]
                [Validation(Required=false)]
                public string CompareDetailUrl { get; set; }

                [NameInMap("compareStatus")]
                [Validation(Required=false)]
                public string CompareStatus { get; set; }

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
