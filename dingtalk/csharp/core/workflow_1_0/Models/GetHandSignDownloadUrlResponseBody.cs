// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkworkflow_1_0.Models
{
    public class GetHandSignDownloadUrlResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetHandSignDownloadUrlResponseBodyResult Result { get; set; }
        public class GetHandSignDownloadUrlResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dingding-file-zjk.oss-cn-zhangjiakouxxxx">https://dingding-file-zjk.oss-cn-zhangjiakouxxxx</a></para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("expireIn")]
            [Validation(Required=false)]
            public long? ExpireIn { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
