// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class GetFinanceAccountResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("accountCode")]
        [Validation(Required=false)]
        public string AccountCode { get; set; }

        [NameInMap("accountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("accountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        [NameInMap("accountRemark")]
        [Validation(Required=false)]
        public string AccountRemark { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("accountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        [NameInMap("accountantBookIdList")]
        [Validation(Required=false)]
        public List<string> AccountantBookIdList { get; set; }

        [NameInMap("amount")]
        [Validation(Required=false)]
        public string Amount { get; set; }

        [NameInMap("bankCode")]
        [Validation(Required=false)]
        public string BankCode { get; set; }

        [NameInMap("bankName")]
        [Validation(Required=false)]
        public string BankName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

    }

}
