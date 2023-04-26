// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class QueryServiceRecordRequest : TeaModel {
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("formUuid")]
        [Validation(Required=false)]
        public string FormUuid { get; set; }

        [NameInMap("hookType")]
        [Validation(Required=false)]
        public string HookType { get; set; }

        [NameInMap("hookUuid")]
        [Validation(Required=false)]
        public string HookUuid { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("invokeAfterDateGMT")]
        [Validation(Required=false)]
        public string InvokeAfterDateGMT { get; set; }

        [NameInMap("invokeBeforeDateGMT")]
        [Validation(Required=false)]
        public string InvokeBeforeDateGMT { get; set; }

        [NameInMap("invokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("requestUrl")]
        [Validation(Required=false)]
        public string RequestUrl { get; set; }

        [NameInMap("sourceUuid")]
        [Validation(Required=false)]
        public string SourceUuid { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("systemToken")]
        [Validation(Required=false)]
        public string SystemToken { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
