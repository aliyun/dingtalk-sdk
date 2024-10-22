// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignUserVerifyResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EsignUserVerifyResponseBodyResult Result { get; set; }
        public class EsignUserVerifyResponseBodyResult : TeaModel {
            [NameInMap("canAccess")]
            [Validation(Required=false)]
            public bool? CanAccess { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
