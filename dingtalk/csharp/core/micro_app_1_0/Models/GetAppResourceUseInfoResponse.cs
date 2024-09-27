// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class GetAppResourceUseInfoResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GetAppResourceUseInfoResponseBody> Body { get; set; }
        public class GetAppResourceUseInfoResponseBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>202301</para>
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8511</para>
            /// </summary>
            [NameInMap("usedNum")]
            [Validation(Required=false)]
            public long? UsedNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("quotaNum")]
            [Validation(Required=false)]
            public long? QuotaNum { get; set; }

        }

    }

}
