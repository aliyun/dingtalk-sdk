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
            /// <summary>
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>psi</para>
                /// </summary>
                [NameInMap("goodsId")]
                [Validation(Required=false)]
                public string GoodsId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>app_function</para>
                /// </summary>
                [NameInMap("goodsType")]
                [Validation(Required=false)]
                public string GoodsType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tungee-ali-crm.oss-cn-hangzhou.aliyuncs.com/app-center/icon/%E8%BF%9B%E9%94%80%E5%AD%98.png">https://tungee-ali-crm.oss-cn-hangzhou.aliyuncs.com/app-center/icon/进销存.png</a></para>
                /// </summary>
                [NameInMap("icon")]
                [Validation(Required=false)]
                public string Icon { get; set; }

                [NameInMap("mainOperationInfo")]
                [Validation(Required=false)]
                public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo MainOperationInfo { get; set; }
                public class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMainOperationInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>GOODS-002</para>
                    /// </summary>
                    [NameInMap("goodsCode")]
                    [Validation(Required=false)]
                    public string GoodsCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://yyy">https://yyy</a></para>
                    /// </summary>
                    [NameInMap("originalUrl")]
                    [Validation(Required=false)]
                    public string OriginalUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://xxx">https://xxx</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("media")]
                [Validation(Required=false)]
                public List<GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia> Media { get; set; }
                public class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListMedia : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>image</para>
                    /// </summary>
                    [NameInMap("mediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://tungee-ali-crm.oss-cn-hangzhou.aliyuncs.com/app-center/banner/%E8%BF%9B%E9%94%80%E5%AD%98%E5%B0%81%E9%9D%A2.png">https://tungee-ali-crm.oss-cn-hangzhou.aliyuncs.com/app-center/banner/进销存封面.png</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                [NameInMap("subOperationInfo")]
                [Validation(Required=false)]
                public GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo SubOperationInfo { get; set; }
                public class GetInAppPurchaseGoodsResponseBodyResultPurchaseGoodsListSubOperationInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>GOODS-2120</para>
                    /// </summary>
                    [NameInMap("goodsCode")]
                    [Validation(Required=false)]
                    public string GoodsCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://yyy">https://yyy</a></para>
                    /// </summary>
                    [NameInMap("originalUrl")]
                    [Validation(Required=false)]
                    public string OriginalUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="https://xxx">https://xxx</a></para>
                    /// </summary>
                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>通过进销存管理，连接企业人、财、物，一站式解决进销存仓库管理难题。让货品成本有据可依，避免盲目采购；合理控制库存，防止滞销/脱销；通过往来对账确保资金安全。</para>
                /// </summary>
                [NameInMap("subTitle")]
                [Validation(Required=false)]
                public string SubTitle { get; set; }

                [NameInMap("tag")]
                [Validation(Required=false)]
                public List<string> Tag { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>进销存</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

        }

    }

}
