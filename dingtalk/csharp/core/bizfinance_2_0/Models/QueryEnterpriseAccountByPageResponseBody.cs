// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class QueryEnterpriseAccountByPageResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<QueryEnterpriseAccountByPageResponseBodyList> List { get; set; }
        public class QueryEnterpriseAccountByPageResponseBodyList : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("accountCode")]
            [Validation(Required=false)]
            public string AccountCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:test@alipay.com">test@alipay.com</a></para>
            /// </summary>
            [NameInMap("accountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>网商银行</para>
            /// </summary>
            [NameInMap("accountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000.33</para>
            /// </summary>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1631526550994</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

        }

    }

}
