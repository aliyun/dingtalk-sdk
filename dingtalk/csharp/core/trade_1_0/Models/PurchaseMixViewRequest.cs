// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0.Models
{
    public class PurchaseMixViewRequest : TeaModel {
        [NameInMap("channelCode")]
        [Validation(Required=false)]
        public string ChannelCode { get; set; }

        [NameInMap("combineActivityId")]
        [Validation(Required=false)]
        public long? CombineActivityId { get; set; }

        [NameInMap("createOrder")]
        [Validation(Required=false)]
        public bool? CreateOrder { get; set; }

        [NameInMap("list")]
        [Validation(Required=false)]
        public List<PurchaseMixViewRequestList> List { get; set; }
        public class PurchaseMixViewRequestList : TeaModel {
            [NameInMap("activityId")]
            [Validation(Required=false)]
            public long? ActivityId { get; set; }

            [NameInMap("articleCode")]
            [Validation(Required=false)]
            public string ArticleCode { get; set; }

            [NameInMap("articleItemCode")]
            [Validation(Required=false)]
            public string ArticleItemCode { get; set; }

            [NameInMap("articleItemId")]
            [Validation(Required=false)]
            public long? ArticleItemId { get; set; }

            [NameInMap("articleItemName")]
            [Validation(Required=false)]
            public string ArticleItemName { get; set; }

            [NameInMap("bizType")]
            [Validation(Required=false)]
            public long? BizType { get; set; }

            [NameInMap("couponId")]
            [Validation(Required=false)]
            public long? CouponId { get; set; }

            [NameInMap("cycNum")]
            [Validation(Required=false)]
            public long? CycNum { get; set; }

            [NameInMap("cycType")]
            [Validation(Required=false)]
            public long? CycType { get; set; }

            [NameInMap("cycUnit")]
            [Validation(Required=false)]
            public long? CycUnit { get; set; }

            [NameInMap("extend1")]
            [Validation(Required=false)]
            public long? Extend1 { get; set; }

            [NameInMap("instanceNum")]
            [Validation(Required=false)]
            public long? InstanceNum { get; set; }

            [NameInMap("isCredit")]
            [Validation(Required=false)]
            public bool? IsCredit { get; set; }

            [NameInMap("itemComponentList")]
            [Validation(Required=false)]
            public List<PurchaseMixViewRequestListItemComponentList> ItemComponentList { get; set; }
            public class PurchaseMixViewRequestListItemComponentList : TeaModel {
                [NameInMap("componentCode")]
                [Validation(Required=false)]
                public string ComponentCode { get; set; }

                [NameInMap("componentName")]
                [Validation(Required=false)]
                public string ComponentName { get; set; }

                [NameInMap("itemPropertyList")]
                [Validation(Required=false)]
                public List<PurchaseMixViewRequestListItemComponentListItemPropertyList> ItemPropertyList { get; set; }
                public class PurchaseMixViewRequestListItemComponentListItemPropertyList : TeaModel {
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("minorItemParamList")]
            [Validation(Required=false)]
            public List<PurchaseMixViewRequestListMinorItemParamList> MinorItemParamList { get; set; }
            public class PurchaseMixViewRequestListMinorItemParamList : TeaModel {
                [NameInMap("minorItemCode")]
                [Validation(Required=false)]
                public string MinorItemCode { get; set; }

                [NameInMap("minorItemGroupCode")]
                [Validation(Required=false)]
                public string MinorItemGroupCode { get; set; }

            }

            [NameInMap("orderParamMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> OrderParamMap { get; set; }

            [NameInMap("orderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            [NameInMap("saleMarketType")]
            [Validation(Required=false)]
            public string SaleMarketType { get; set; }

            [NameInMap("saleOrgId")]
            [Validation(Required=false)]
            public long? SaleOrgId { get; set; }

            [NameInMap("subQuantity")]
            [Validation(Required=false)]
            public long? SubQuantity { get; set; }

            [NameInMap("tradeModelType")]
            [Validation(Required=false)]
            public string TradeModelType { get; set; }

        }

        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("mergeOrderName")]
        [Validation(Required=false)]
        public string MergeOrderName { get; set; }

        [NameInMap("needModelTypeList")]
        [Validation(Required=false)]
        public List<string> NeedModelTypeList { get; set; }

        [NameInMap("objId")]
        [Validation(Required=false)]
        public long? ObjId { get; set; }

        [NameInMap("objType")]
        [Validation(Required=false)]
        public long? ObjType { get; set; }

        [NameInMap("orderParamMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> OrderParamMap { get; set; }

        [NameInMap("outerTradeCode")]
        [Validation(Required=false)]
        public string OuterTradeCode { get; set; }

        [NameInMap("outerTradeType")]
        [Validation(Required=false)]
        public string OuterTradeType { get; set; }

        [NameInMap("planId")]
        [Validation(Required=false)]
        public long? PlanId { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

        [NameInMap("unPay")]
        [Validation(Required=false)]
        public bool? UnPay { get; set; }

    }

}
