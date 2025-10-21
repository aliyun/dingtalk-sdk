// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0.Models
{
    public class TiktokShopAuthCallbackRequest : TeaModel {
        [NameInMap("sellerType")]
        [Validation(Required=false)]
        public string SellerType { get; set; }

        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("shopName")]
        [Validation(Required=false)]
        public string ShopName { get; set; }

        [NameInMap("shopRegion")]
        [Validation(Required=false)]
        public string ShopRegion { get; set; }

    }

}
