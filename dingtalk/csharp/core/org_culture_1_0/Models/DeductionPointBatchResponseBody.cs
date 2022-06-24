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
                public string Code { get; set; }
                public string InvokeStatus { get; set; }
                public string Msg { get; set; }
                public string OutId { get; set; }
                public string UserId { get; set; }
            }
        };

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
