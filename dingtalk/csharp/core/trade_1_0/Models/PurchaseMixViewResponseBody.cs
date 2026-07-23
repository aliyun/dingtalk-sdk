// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class PurchaseMixViewResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public PurchaseMixViewResponseBodyResult Result { get; set; }
        public class PurchaseMixViewResponseBodyResult : TeaModel {
            [NameInMap("aliyunArticleItemViewUnitList")]
            [Validation(Required=false)]
            public List<PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList> AliyunArticleItemViewUnitList { get; set; }
            public class PurchaseMixViewResponseBodyResultAliyunArticleItemViewUnitList : TeaModel {
                [NameInMap("actualPayFee")]
                [Validation(Required=false)]
                public double? ActualPayFee { get; set; }

                [NameInMap("articleCode")]
                [Validation(Required=false)]
                public string ArticleCode { get; set; }

                [NameInMap("articleItemCode")]
                [Validation(Required=false)]
                public string ArticleItemCode { get; set; }

                [NameInMap("bizTagList")]
                [Validation(Required=false)]
                public List<string> BizTagList { get; set; }

                [NameInMap("endDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                [NameInMap("orderType")]
                [Validation(Required=false)]
                public string OrderType { get; set; }

                [NameInMap("payFee")]
                [Validation(Required=false)]
                public double? PayFee { get; set; }

                [NameInMap("startDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

            [NameInMap("mixPromotionVO")]
            [Validation(Required=false)]
            public PurchaseMixViewResponseBodyResultMixPromotionVO MixPromotionVO { get; set; }
            public class PurchaseMixViewResponseBodyResultMixPromotionVO : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public long? ActivityId { get; set; }

                [NameInMap("activityName")]
                [Validation(Required=false)]
                public string ActivityName { get; set; }

                [NameInMap("activityUrl")]
                [Validation(Required=false)]
                public string ActivityUrl { get; set; }

                [NameInMap("endTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("extendParam")]
                [Validation(Required=false)]
                public Dictionary<string, object> ExtendParam { get; set; }

                [NameInMap("forbiddenCoupon")]
                [Validation(Required=false)]
                public bool? ForbiddenCoupon { get; set; }

                [NameInMap("isSelected")]
                [Validation(Required=false)]
                public bool? IsSelected { get; set; }

                [NameInMap("marketActivityId")]
                [Validation(Required=false)]
                public long? MarketActivityId { get; set; }

                [NameInMap("promotionId")]
                [Validation(Required=false)]
                public long? PromotionId { get; set; }

                [NameInMap("promotionName")]
                [Validation(Required=false)]
                public string PromotionName { get; set; }

                [NameInMap("promotionType")]
                [Validation(Required=false)]
                public string PromotionType { get; set; }

                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("startTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("recommendedMarketingCollocationDTO")]
            [Validation(Required=false)]
            public PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO RecommendedMarketingCollocationDTO { get; set; }
            public class PurchaseMixViewResponseBodyResultRecommendedMarketingCollocationDTO : TeaModel {
                [NameInMap("activityId")]
                [Validation(Required=false)]
                public long? ActivityId { get; set; }

                [NameInMap("couponId")]
                [Validation(Required=false)]
                public long? CouponId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
