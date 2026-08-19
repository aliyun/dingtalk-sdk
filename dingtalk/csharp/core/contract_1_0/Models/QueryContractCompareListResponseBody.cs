// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryContractCompareListResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryContractCompareListResponseBodyResult Result { get; set; }
        public class QueryContractCompareListResponseBodyResult : TeaModel {
            [NameInMap("currentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("data")]
            [Validation(Required=false)]
            public List<QueryContractCompareListResponseBodyResultData> Data { get; set; }
            public class QueryContractCompareListResponseBodyResultData : TeaModel {
                [NameInMap("comparativeFileName")]
                [Validation(Required=false)]
                public string ComparativeFileName { get; set; }

                [NameInMap("compareStatus")]
                [Validation(Required=false)]
                public string CompareStatus { get; set; }

                [NameInMap("compareTaskId")]
                [Validation(Required=false)]
                public string CompareTaskId { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("initiatorUid")]
                [Validation(Required=false)]
                public string InitiatorUid { get; set; }

                [NameInMap("requestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                [NameInMap("result")]
                [Validation(Required=false)]
                public string Result { get; set; }

                [NameInMap("standardFileName")]
                [Validation(Required=false)]
                public string StandardFileName { get; set; }

            }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
