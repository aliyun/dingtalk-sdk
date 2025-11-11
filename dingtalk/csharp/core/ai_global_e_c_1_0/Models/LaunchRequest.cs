// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkai_global_e_c_1_0.Models
{
    public class LaunchRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("imageUrls")]
        [Validation(Required=false)]
        public List<string> ImageUrls { get; set; }

        [NameInMap("platform")]
        [Validation(Required=false)]
        public List<string> Platform { get; set; }

        [NameInMap("productName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("sellingPoints")]
        [Validation(Required=false)]
        public List<string> SellingPoints { get; set; }

        [NameInMap("sourceData")]
        [Validation(Required=false)]
        public string SourceData { get; set; }

        [NameInMap("variants")]
        [Validation(Required=false)]
        public List<LaunchRequestVariants> Variants { get; set; }
        public class LaunchRequestVariants : TeaModel {
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<string> Images { get; set; }

            [NameInMap("optionValues")]
            [Validation(Required=false)]
            public List<LaunchRequestVariantsOptionValues> OptionValues { get; set; }
            public class LaunchRequestVariantsOptionValues : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("price")]
            [Validation(Required=false)]
            public string Price { get; set; }

            [NameInMap("sku")]
            [Validation(Required=false)]
            public string Sku { get; set; }

        }

        [NameInMap("videoUrls")]
        [Validation(Required=false)]
        public List<string> VideoUrls { get; set; }

    }

}
