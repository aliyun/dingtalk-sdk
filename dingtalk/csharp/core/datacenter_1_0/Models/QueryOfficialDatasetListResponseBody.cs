// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdatacenter_1_0.Models
{
    public class QueryOfficialDatasetListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryOfficialDatasetListResponseBodyResult Result { get; set; }
        public class QueryOfficialDatasetListResponseBodyResult : TeaModel {
            [NameInMap("rows")]
            [Validation(Required=false)]
            public List<QueryOfficialDatasetListResponseBodyResultRows> Rows { get; set; }
            public class QueryOfficialDatasetListResponseBodyResultRows : TeaModel {
                public string DisplayName { get; set; }
                public string DsId { get; set; }
            }
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
