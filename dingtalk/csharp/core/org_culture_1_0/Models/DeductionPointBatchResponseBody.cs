// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class DeductionPointBatchResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public DeductionPointBatchResponseBodyResult Result { get; set; }
        public class DeductionPointBatchResponseBodyResult : TeaModel {
            [NameInMap("openPointInvokeResultDTOS")]
            [Validation(Required=false)]
            public List<DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS> OpenPointInvokeResultDTOS { get; set; }
            public class DeductionPointBatchResponseBodyResultOpenPointInvokeResultDTOS : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("invokeStatus")]
                [Validation(Required=false)]
                public string InvokeStatus { get; set; }

                [NameInMap("msg")]
                [Validation(Required=false)]
                public string Msg { get; set; }

                [NameInMap("outId")]
                [Validation(Required=false)]
                public string OutId { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
