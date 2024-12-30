// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryContractExtractResultResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryContractExtractResultResponseBodyResult Result { get; set; }
        public class QueryContractExtractResultResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public QueryContractExtractResultResponseBodyResultData Data { get; set; }
            public class QueryContractExtractResultResponseBodyResultData : TeaModel {
                [NameInMap("extractEntities")]
                [Validation(Required=false)]
                public List<QueryContractExtractResultResponseBodyResultDataExtractEntities> ExtractEntities { get; set; }
                public class QueryContractExtractResultResponseBodyResultDataExtractEntities : TeaModel {
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("extractStatus")]
                [Validation(Required=false)]
                public string ExtractStatus { get; set; }

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
