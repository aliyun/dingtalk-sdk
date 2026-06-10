// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class QueryImportStatusResponseBody : TeaModel {
        [NameInMap("count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("importId")]
        [Validation(Required=false)]
        public string ImportId { get; set; }

        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tableIds")]
        [Validation(Required=false)]
        public List<string> TableIds { get; set; }

    }

}
