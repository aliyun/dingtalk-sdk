// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class CreateAppGoodsServiceConversationRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isvUserId")]
        [Validation(Required=false)]
        public string IsvUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

    }

}
