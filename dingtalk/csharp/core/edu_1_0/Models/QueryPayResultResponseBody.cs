// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class QueryPayResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>状态，取值：10：待支付，11：关单，20：支付成功</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
