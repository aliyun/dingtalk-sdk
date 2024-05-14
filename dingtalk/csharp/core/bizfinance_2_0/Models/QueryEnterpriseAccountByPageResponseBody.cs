// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryEnterpriseAccountByPageResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryEnterpriseAccountByPageResponseBodyList> List { get; set; }
        public class QueryEnterpriseAccountByPageResponseBodyList : TeaModel {
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

}
