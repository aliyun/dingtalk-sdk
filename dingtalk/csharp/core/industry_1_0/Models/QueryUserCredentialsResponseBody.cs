// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class QueryUserCredentialsResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<QueryUserCredentialsResponseBodyContent> Content { get; set; }
        public class QueryUserCredentialsResponseBodyContent : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("credentialList")]
            [Validation(Required=false)]
            public List<QueryUserCredentialsResponseBodyContentCredentialList> CredentialList { get; set; }
            public class QueryUserCredentialsResponseBodyContentCredentialList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("credentialName")]
                [Validation(Required=false)]
                public string CredentialName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("credentialType")]
                [Validation(Required=false)]
                public int? CredentialType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("termOfValidity")]
                [Validation(Required=false)]
                public string TermOfValidity { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
