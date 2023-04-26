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
            [NameInMap("credentialList")]
            [Validation(Required=false)]
            public List<QueryUserCredentialsResponseBodyContentCredentialList> CredentialList { get; set; }
            public class QueryUserCredentialsResponseBodyContentCredentialList : TeaModel {
                [NameInMap("credentialName")]
                [Validation(Required=false)]
                public string CredentialName { get; set; }

                [NameInMap("credentialType")]
                [Validation(Required=false)]
                public int? CredentialType { get; set; }

                [NameInMap("termOfValidity")]
                [Validation(Required=false)]
                public string TermOfValidity { get; set; }

            }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
