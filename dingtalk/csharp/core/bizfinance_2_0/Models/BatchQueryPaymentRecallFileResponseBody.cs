// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class BatchQueryPaymentRecallFileResponseBody : TeaModel {
        [NameInMap("paymentRecallFileList")]
        [Validation(Required=false)]
        public List<BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList> PaymentRecallFileList { get; set; }
        public class BatchQueryPaymentRecallFileResponseBodyPaymentRecallFileList : TeaModel {
            [NameInMap("detailId")]
            [Validation(Required=false)]
            public string DetailId { get; set; }

            [NameInMap("fileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("fileSize")]
            [Validation(Required=false)]
            public string FileSize { get; set; }

            [NameInMap("fileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("recallFileUrl")]
            [Validation(Required=false)]
            public string RecallFileUrl { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

    }

}
