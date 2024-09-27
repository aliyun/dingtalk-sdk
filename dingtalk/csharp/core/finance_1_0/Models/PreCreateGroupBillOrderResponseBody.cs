// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class PreCreateGroupBillOrderResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public PreCreateGroupBillOrderResponseBodyResult Result { get; set; }
        public class PreCreateGroupBillOrderResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2023100914312930910100002107362525</para>
            /// </summary>
            [NameInMap("orderNo")]
            [Validation(Required=false)]
            public string OrderNo { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
