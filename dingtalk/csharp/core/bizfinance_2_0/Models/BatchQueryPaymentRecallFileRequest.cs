// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class BatchQueryPaymentRecallFileRequest : TeaModel {
        [NameInMap("detailIdList")]
        [Validation(Required=false)]
        public List<string> DetailIdList { get; set; }

        [NameInMap("opeator")]
        [Validation(Required=false)]
        public string Opeator { get; set; }

    }

}
