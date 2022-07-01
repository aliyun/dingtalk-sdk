// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserCredentialsResponseBody : TeaModel {
        /// <summary>
        /// 人员证书
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryUserCredentialsResponseBodyContent> Content { get; set; }
        public class QueryUserCredentialsResponseBodyContent : TeaModel {
            /// <summary>
            /// 证书列表
            /// </summary>
            [NameInMap("credentialList")]
            [Validation(Required=false)]
            public List<QueryUserCredentialsResponseBodyContentCredentialList> CredentialList { get; set; }
            public class QueryUserCredentialsResponseBodyContentCredentialList : TeaModel {
                /// <summary>
                /// 证书名称
                /// </summary>
                [NameInMap("credentialName")]
                [Validation(Required=false)]
                public string CredentialName { get; set; }

                /// <summary>
                /// 证书类型
                /// </summary>
                [NameInMap("credentialType")]
                [Validation(Required=false)]
                public int? CredentialType { get; set; }

                /// <summary>
                /// 有效日期
                /// </summary>
                [NameInMap("termOfValidity")]
                [Validation(Required=false)]
                public string TermOfValidity { get; set; }

            }

            /// <summary>
            /// 用户id
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
