// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryPayAccountListResponseBody : TeaModel {
        /// <summary>
        /// 账号列表
        /// </summary>
        [NameInMap("payAccountVOList")]
        [Validation(Required=false)]
        public List<QueryPayAccountListResponseBodyPayAccountVOList> PayAccountVOList { get; set; }
        public class QueryPayAccountListResponseBodyPayAccountVOList : TeaModel {
            /// <summary>
            /// 付款账号（脱敏）
            /// </summary>
            [NameInMap("accountNo")]
            [Validation(Required=false)]
            public string AccountNo { get; set; }

            /// <summary>
            /// 账号名称
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// 账户类型
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// 账户备注
            /// </summary>
            [NameInMap("accountRemark")]
            [Validation(Required=false)]
            public string AccountRemark { get; set; }

            /// <summary>
            /// 账号唯一id
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// 账户分类
            /// </summary>
            [NameInMap("accountClass")]
            [Validation(Required=false)]
            public string AccountClass { get; set; }

        }

    }

}
