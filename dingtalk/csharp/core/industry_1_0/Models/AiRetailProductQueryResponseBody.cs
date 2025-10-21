// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class AiRetailProductQueryResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<AiRetailProductQueryResponseBodyData> Data { get; set; }
        public class AiRetailProductQueryResponseBodyData : TeaModel {
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            [NameInMap("barcodes")]
            [Validation(Required=false)]
            public string Barcodes { get; set; }

            [NameInMap("brand")]
            [Validation(Required=false)]
            public string Brand { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("enable")]
            [Validation(Required=false)]
            public int? Enable { get; set; }

            [NameInMap("imageFileIds")]
            [Validation(Required=false)]
            public string ImageFileIds { get; set; }

            [NameInMap("itemNumbers")]
            [Validation(Required=false)]
            public string ItemNumbers { get; set; }

            [NameInMap("price")]
            [Validation(Required=false)]
            public float? Price { get; set; }

            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("productFab")]
            [Validation(Required=false)]
            public string ProductFab { get; set; }

            [NameInMap("productId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            [NameInMap("productInfo")]
            [Validation(Required=false)]
            public string ProductInfo { get; set; }

            [NameInMap("productName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

    }

}
