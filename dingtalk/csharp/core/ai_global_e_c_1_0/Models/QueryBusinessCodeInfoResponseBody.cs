// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0.Models
{
    public class QueryBusinessCodeInfoResponseBody : TeaModel {
        [NameInMap("businessCode")]
        [Validation(Required=false)]
        public string BusinessCode { get; set; }

        [NameInMap("imageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        [NameInMap("imageUrls")]
        [Validation(Required=false)]
        public List<string> ImageUrls { get; set; }

        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("skuList")]
        [Validation(Required=false)]
        public List<QueryBusinessCodeInfoResponseBodySkuList> SkuList { get; set; }
        public class QueryBusinessCodeInfoResponseBodySkuList : TeaModel {
            [NameInMap("imageUrl")]
            [Validation(Required=false)]
            public string ImageUrl { get; set; }

            [NameInMap("skuId")]
            [Validation(Required=false)]
            public string SkuId { get; set; }

        }

    }

}
