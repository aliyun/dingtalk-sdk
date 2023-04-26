// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryUserAgreementResponseBody : TeaModel {
        [NameInMap("agreementNo")]
        [Validation(Required=false)]
        public string AgreementNo { get; set; }

        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        [NameInMap("gmtExpire")]
        [Validation(Required=false)]
        public string GmtExpire { get; set; }

        [NameInMap("gmtSign")]
        [Validation(Required=false)]
        public string GmtSign { get; set; }

        [NameInMap("gmtValid")]
        [Validation(Required=false)]
        public string GmtValid { get; set; }

        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        [NameInMap("payChannelAccountName")]
        [Validation(Required=false)]
        public string PayChannelAccountName { get; set; }

        [NameInMap("payChannelAccountNo")]
        [Validation(Required=false)]
        public string PayChannelAccountNo { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
