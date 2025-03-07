// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryContractAppsExtractResultResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryContractAppsExtractResultResponseBodyResult Result { get; set; }
        public class QueryContractAppsExtractResultResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public QueryContractAppsExtractResultResponseBodyResultData Data { get; set; }
            public class QueryContractAppsExtractResultResponseBodyResultData : TeaModel {
                [NameInMap("extractEntities")]
                [Validation(Required=false)]
                public List<QueryContractAppsExtractResultResponseBodyResultDataExtractEntities> ExtractEntities { get; set; }
                public class QueryContractAppsExtractResultResponseBodyResultDataExtractEntities : TeaModel {
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
