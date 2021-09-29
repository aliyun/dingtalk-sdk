// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetActivityButtonListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetActivityButtonListResponseBodyResult> Result { get; set; }
        public class GetActivityButtonListResponseBodyResult : TeaModel {
            /// <summary>
            /// aliasEn
            /// </summary>
            [NameInMap("aliasInEnglish")]
            [Validation(Required=false)]
            public string AliasInEnglish { get; set; }

            /// <summary>
            /// alias
            /// </summary>
            [NameInMap("aliasInChinese")]
            [Validation(Required=false)]
            public string AliasInChinese { get; set; }

        }

    }

}
