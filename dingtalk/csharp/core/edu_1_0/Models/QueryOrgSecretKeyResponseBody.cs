// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryOrgSecretKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("universitySecretKeyInfo")]
        [Validation(Required=false)]
        public QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo UniversitySecretKeyInfo { get; set; }
        public class QueryOrgSecretKeyResponseBodyUniversitySecretKeyInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ghiufhk123</para>
            /// </summary>
            [NameInMap("secretKey")]
            [Validation(Required=false)]
            public string SecretKey { get; set; }

        }

    }

}
