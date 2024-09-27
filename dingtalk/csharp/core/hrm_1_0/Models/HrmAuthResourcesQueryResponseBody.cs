// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class HrmAuthResourcesQueryResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<HrmAuthResourcesQueryResponseBodyResult> Result { get; set; }
        public class HrmAuthResourcesQueryResponseBodyResult : TeaModel {
            [NameInMap("authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/signSetting/manage/*</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

    }

}
