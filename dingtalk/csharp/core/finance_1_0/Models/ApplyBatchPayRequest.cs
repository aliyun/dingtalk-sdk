// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class ApplyBatchPayRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orderNo")]
        [Validation(Required=false)]
        public string OrderNo { get; set; }

        [NameInMap("passBackParams")]
        [Validation(Required=false)]
        public Dictionary<string, object> PassBackParams { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payTerminal")]
        [Validation(Required=false)]
        public string PayTerminal { get; set; }

        [NameInMap("returnUrl")]
        [Validation(Required=false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("staffId")]
        [Validation(Required=false)]
        public string StaffId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("transAmount")]
        [Validation(Required=false)]
        public string TransAmount { get; set; }

        [NameInMap("transExpireTime")]
        [Validation(Required=false)]
        public string TransExpireTime { get; set; }

    }

}
