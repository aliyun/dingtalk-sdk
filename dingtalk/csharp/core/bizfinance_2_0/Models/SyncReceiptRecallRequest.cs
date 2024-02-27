// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class SyncReceiptRecallRequest : TeaModel {
        [NameInMap("fileDownloadUrl")]
        [Validation(Required=false)]
        public string FileDownloadUrl { get; set; }

        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

    }

}
