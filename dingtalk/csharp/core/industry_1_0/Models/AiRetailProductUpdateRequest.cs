// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class AiRetailProductUpdateRequest : TeaModel {
        [NameInMap("attribute")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attribute { get; set; }

        [NameInMap("barcodes")]
        [Validation(Required=false)]
        public List<string> Barcodes { get; set; }

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
        public List<string> ImageFileIds { get; set; }

        [NameInMap("itemNumbers")]
        [Validation(Required=false)]
        public List<string> ItemNumbers { get; set; }

        [NameInMap("price")]
        [Validation(Required=false)]
        public float? Price { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>办公室的电话是：13222333232</para>
        /// </summary>
        [NameInMap("productFab")]
        [Validation(Required=false)]
        public string ProductFab { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxxx.com/xxxxxx">https://xxxxxxx.com/xxxxxx</a></para>
        /// </summary>
        [NameInMap("productInfo")]
        [Validation(Required=false)]
        public string ProductInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>办公室的电话是多少</para>
        /// </summary>
        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

    }

}
