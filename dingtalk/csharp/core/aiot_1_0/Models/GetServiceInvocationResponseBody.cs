// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkaiot_1_0.Models
{
    public class GetServiceInvocationResponseBody : TeaModel {
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public string CompletedAt { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("deviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        [NameInMap("invocationId")]
        [Validation(Required=false)]
        public string InvocationId { get; set; }

        [NameInMap("outputData")]
        [Validation(Required=false)]
        public Dictionary<string, object> OutputData { get; set; }

        [NameInMap("processingTimeMs")]
        [Validation(Required=false)]
        public long? ProcessingTimeMs { get; set; }

        [NameInMap("productKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
