// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryCustomEntryProcessesResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryCustomEntryProcessesResponseBodyList> List { get; set; }
        public class QueryCustomEntryProcessesResponseBodyList : TeaModel {
            [NameInMap("formDesc")]
            [Validation(Required=false)]
            public string FormDesc { get; set; }

            [NameInMap("formId")]
            [Validation(Required=false)]
            public string FormId { get; set; }

            [NameInMap("formName")]
            [Validation(Required=false)]
            public string FormName { get; set; }

            [NameInMap("shortUrl")]
            [Validation(Required=false)]
            public string ShortUrl { get; set; }

        }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

    }

}
