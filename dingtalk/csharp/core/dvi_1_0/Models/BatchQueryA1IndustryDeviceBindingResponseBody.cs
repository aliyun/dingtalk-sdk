// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdvi_1_0.Models
{
    public class BatchQueryA1IndustryDeviceBindingResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public BatchQueryA1IndustryDeviceBindingResponseBodyResult Result { get; set; }
        public class BatchQueryA1IndustryDeviceBindingResponseBodyResult : TeaModel {
            [NameInMap("partialSuccess")]
            [Validation(Required=false)]
            public bool? PartialSuccess { get; set; }

            [NameInMap("results")]
            [Validation(Required=false)]
            public List<BatchQueryA1IndustryDeviceBindingResponseBodyResultResults> Results { get; set; }
            public class BatchQueryA1IndustryDeviceBindingResponseBodyResultResults : TeaModel {
                [NameInMap("bindTimestamp")]
                [Validation(Required=false)]
                public long? BindTimestamp { get; set; }

                [NameInMap("bindingStatus")]
                [Validation(Required=false)]
                public string BindingStatus { get; set; }

                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public int? ErrorCode { get; set; }

                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("sn")]
                [Validation(Required=false)]
                public string Sn { get; set; }

                [NameInMap("success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

                [NameInMap("unionId")]
                [Validation(Required=false)]
                public string UnionId { get; set; }

            }

        }

    }

}
