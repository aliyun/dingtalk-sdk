// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetInAppPurchaseGoodsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetInAppPurchaseGoodsResponseBodyResult Result { get; set; }
        public class GetInAppPurchaseGoodsResponseBodyResult : TeaModel {
            [NameInMap("orderVersion")]
            [Validation(Required=false)]
            public string OrderVersion { get; set; }

            [NameInMap("purchaseGoodsList")]
            [Validation(Required=false)]
            public List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList> PurchaseGoodsList { get; set; }
            public class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsList : TeaModel {
                [NameInMap("applicableVersion")]
                [Validation(Required=false)]
                public List<string> ApplicableVersion { get; set; }

                [NameInMap("applyNum")]
                [Validation(Required=false)]
                public long? ApplyNum { get; set; }

                [NameInMap("belongIndustry")]
                [Validation(Required=false)]
                public List<string> BelongIndustry { get; set; }

                [NameInMap("goodsId")]
                [Validation(Required=false)]
                public string GoodsId { get; set; }

                [NameInMap("goodsType")]
                [Validation(Required=false)]
                public string GoodsType { get; set; }

                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("mainOperationInfo")]
                [Validation(Required=false)]
                public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo MainOperationInfo { get; set; }
                public class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo : TeaModel {
                    [NameInMap("goodsCode")]
                    [Validation(Required=false)]
                    public string GoodsCode { get; set; }

                    [NameInMap("originalUrl")]
                    [Validation(Required=false)]
                    public string OriginalUrl { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("media")]
                [Validation(Required=false)]
                public List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia> Media { get; set; }
                public class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia : TeaModel {
                    [NameInMap("mediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                [NameInMap("subOperationInfo")]
                [Validation(Required=false)]
                public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo SubOperationInfo { get; set; }
                public class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo : TeaModel {
                    [NameInMap("goodsCode")]
                    [Validation(Required=false)]
                    public string GoodsCode { get; set; }

                    [NameInMap("originalUrl")]
                    [Validation(Required=false)]
                    public string OriginalUrl { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("subTitle")]
                [Validation(Required=false)]
                public string SubTitle { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public List<string> Tag { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
