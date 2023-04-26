// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class QueryServiceRecordResponseBody : TeaModel {
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<QueryServiceRecordResponseBodyValues> Values { get; set; }
        public class QueryServiceRecordResponseBodyValues : TeaModel {
            [NameInMap("formInstanceId")]
            [Validation(Required=false)]
            public string FormInstanceId { get; set; }

            [NameInMap("formUuid")]
            [Validation(Required=false)]
            public string FormUuid { get; set; }

            [NameInMap("hookType")]
            [Validation(Required=false)]
            public string HookType { get; set; }

            [NameInMap("hookUuid")]
            [Validation(Required=false)]
            public string HookUuid { get; set; }

            [NameInMap("invokeParameter")]
            [Validation(Required=false)]
            public string InvokeParameter { get; set; }

            [NameInMap("invokeResult")]
            [Validation(Required=false)]
            public string InvokeResult { get; set; }

            [NameInMap("invokeStatus")]
            [Validation(Required=false)]
            public string InvokeStatus { get; set; }

            [NameInMap("invokeSuccess")]
            [Validation(Required=false)]
            public string InvokeSuccess { get; set; }

            [NameInMap("invokeUrl")]
            [Validation(Required=false)]
            public string InvokeUrl { get; set; }

            [NameInMap("serviceContent")]
            [Validation(Required=false)]
            public string ServiceContent { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("serviceParameter")]
            [Validation(Required=false)]
            public string ServiceParameter { get; set; }

            [NameInMap("sourceUuid")]
            [Validation(Required=false)]
            public string SourceUuid { get; set; }

        }

    }

}
