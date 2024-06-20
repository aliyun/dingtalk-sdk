// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class FinanceLoanNotifyRegisterRequest : TeaModel {
        [NameInMap("completeTime")]
        [Validation(Required=false)]
        public string CompleteTime { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        [NameInMap("idCardNo")]
        [Validation(Required=false)]
        public string IdCardNo { get; set; }

        [NameInMap("openChannelName")]
        [Validation(Required=false)]
        public string OpenChannelName { get; set; }

        [NameInMap("openProductCode")]
        [Validation(Required=false)]
        public string OpenProductCode { get; set; }

        [NameInMap("openProductName")]
        [Validation(Required=false)]
        public string OpenProductName { get; set; }

        [NameInMap("openProductType")]
        [Validation(Required=false)]
        public string OpenProductType { get; set; }

        [NameInMap("processingStatus")]
        [Validation(Required=false)]
        public string ProcessingStatus { get; set; }

        [NameInMap("refuseCode")]
        [Validation(Required=false)]
        public string RefuseCode { get; set; }

        [NameInMap("refuseReason")]
        [Validation(Required=false)]
        public string RefuseReason { get; set; }

        [NameInMap("registerNo")]
        [Validation(Required=false)]
        public string RegisterNo { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public string SubmitTime { get; set; }

        [NameInMap("userMobile")]
        [Validation(Required=false)]
        public string UserMobile { get; set; }

    }

}
