// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class EsignSyncEventResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public EsignSyncEventResponseBodyResult Result { get; set; }
        public class EsignSyncEventResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>外部服务异常</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
