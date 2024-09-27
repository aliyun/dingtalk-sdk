// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryPayAccountListResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("payAccountVOList")]
        [Validation(Required=false)]
        public List<QueryPayAccountListResponseBodyPayAccountVOList> PayAccountVOList { get; set; }
        public class QueryPayAccountListResponseBodyPayAccountVOList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>B</para>
            /// </summary>
            [NameInMap("accountClass")]
            [Validation(Required=false)]
            public string AccountClass { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20210912001</para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>139****1</para>
            /// </summary>
            [NameInMap("accountNo")]
            [Validation(Required=false)]
            public string AccountNo { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>备注</para>
            /// </summary>
            [NameInMap("accountRemark")]
            [Validation(Required=false)]
            public string AccountRemark { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALIPAY</para>
            /// </summary>
            [NameInMap("accountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

        }

    }

}
