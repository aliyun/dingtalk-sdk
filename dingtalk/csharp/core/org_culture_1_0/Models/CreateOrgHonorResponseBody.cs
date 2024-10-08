// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkorg_culture_1_0.Models
{
    public class CreateOrgHonorResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateOrgHonorResponseBodyResult Result { get; set; }
        public class CreateOrgHonorResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10000283</para>
            /// </summary>
            [NameInMap("honorId")]
            [Validation(Required=false)]
            public string HonorId { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
