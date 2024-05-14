// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryPayAccountListResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("payAccountVOList")]
        [Validation(Required=false)]
        public List<QueryPayAccountListResponseBodyPayAccountVOList> PayAccountVOList { get; set; }
        public class QueryPayAccountListResponseBodyPayAccountVOList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("accountClass")]
            [Validation(Required=false)]
            public string AccountClass { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("accountNo")]
            [Validation(Required=false)]
            public string AccountNo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("accountRemark")]
            [Validation(Required=false)]
            public string AccountRemark { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

        }

    }

}
