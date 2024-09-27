// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetLastOrgAuthDataResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>营业执照照片不清晰</para>
        /// </summary>
        [NameInMap("authRemark")]
        [Validation(Required=false)]
        public string AuthRemark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("authStatus")]
        [Validation(Required=false)]
        public int? AuthStatus { get; set; }

    }

}
