// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class UserAgreementPageSignRequest : TeaModel {
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        [NameInMap("bizScene")]
        [Validation(Required=false)]
        public string BizScene { get; set; }

        [NameInMap("instId")]
        [Validation(Required=false)]
        public string InstId { get; set; }

        [NameInMap("payChannel")]
        [Validation(Required=false)]
        public string PayChannel { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("returnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        [NameInMap("signScene")]
        [Validation(Required=false)]
        public string SignScene { get; set; }

        [NameInMap("subInstId")]
        [Validation(Required=false)]
        public string SubInstId { get; set; }

        [NameInMap("subMerchantName")]
        [Validation(Required=false)]
        public string SubMerchantName { get; set; }

        [NameInMap("subMerchantServiceDesc")]
        [Validation(Required=false)]
        public string SubMerchantServiceDesc { get; set; }

        [NameInMap("subMerchantServiceName")]
        [Validation(Required=false)]
        public string SubMerchantServiceName { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
