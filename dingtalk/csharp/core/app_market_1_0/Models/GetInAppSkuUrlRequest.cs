// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models
{
    public class GetInAppSkuUrlRequest : TeaModel {
        [NameInMap("callbackPage")]
        [Validation(Required=false)]
        public string CallbackPage { get; set; }

        [NameInMap("extendParam")]
        [Validation(Required=false)]
        public string ExtendParam { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("goodsCode")]
        [Validation(Required=false)]
        public string GoodsCode { get; set; }

        [NameInMap("itemCode")]
        [Validation(Required=false)]
        public string ItemCode { get; set; }

    }

}
