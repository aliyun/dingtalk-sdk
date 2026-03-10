// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryPaymentRecallFileVTwoResponseBody : TeaModel {
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("paymentRecallFileList")]
        [Validation(Required=false)]
        public List<QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList> PaymentRecallFileList { get; set; }
        public class QueryPaymentRecallFileVTwoResponseBodyPaymentRecallFileList : TeaModel {
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

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("orderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

            [NameInMap("previewUrl")]
            [Validation(Required=false)]
            public string PreviewUrl { get; set; }

            [NameInMap("recallFileUrl")]
            [Validation(Required=false)]
            public string RecallFileUrl { get; set; }

            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

        }

    }

}
