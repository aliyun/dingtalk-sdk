// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CancelOrderResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("needRetry")]
        [Validation(Required=false)]
        public bool? NeedRetry { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("tradeAction")]
        [Validation(Required=false)]
        public string TradeAction { get; set; }

    }

}
