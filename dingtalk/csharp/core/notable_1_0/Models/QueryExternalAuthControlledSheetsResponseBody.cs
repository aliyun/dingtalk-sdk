// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class QueryExternalAuthControlledSheetsResponseBody : TeaModel {
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("sheets")]
        [Validation(Required=false)]
        public List<QueryExternalAuthControlledSheetsResponseBodySheets> Sheets { get; set; }
        public class QueryExternalAuthControlledSheetsResponseBodySheets : TeaModel {
            [NameInMap("externalAuthType")]
            [Validation(Required=false)]
            public string ExternalAuthType { get; set; }

            [NameInMap("externalConfig")]
            [Validation(Required=false)]
            public string ExternalConfig { get; set; }

            [NameInMap("markedBy")]
            [Validation(Required=false)]
            public string MarkedBy { get; set; }

            [NameInMap("markedTime")]
            [Validation(Required=false)]
            public long? MarkedTime { get; set; }

            [NameInMap("sheetId")]
            [Validation(Required=false)]
            public string SheetId { get; set; }

            [NameInMap("sheetName")]
            [Validation(Required=false)]
            public string SheetName { get; set; }

        }

    }

}
