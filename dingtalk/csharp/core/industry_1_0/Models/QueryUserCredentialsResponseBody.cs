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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("credentialList")]
            [Validation(Required=false)]
            public List<QueryUserCredentialsResponseBodyContentCredentialList> CredentialList { get; set; }
            public class QueryUserCredentialsResponseBodyContentCredentialList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>医生资格证书</para>
                /// </summary>
                [NameInMap("credentialName")]
                [Validation(Required=false)]
                public string CredentialName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("credentialType")]
                [Validation(Required=false)]
                public int? CredentialType { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-01</para>
                /// </summary>
                [NameInMap("termOfValidity")]
                [Validation(Required=false)]
                public string TermOfValidity { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
