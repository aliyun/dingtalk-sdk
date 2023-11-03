// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0.Models
{
    public class SyncBusinessSignInfoRequest : TeaModel {
        [NameInMap("bizTypeList")]
        [Validation(Required=false)]
        public List<string> BizTypeList { get; set; }

        [NameInMap("gmtOrgPay")]
        [Validation(Required=false)]
        public string GmtOrgPay { get; set; }

        [NameInMap("gmtSign")]
        [Validation(Required=false)]
        public string GmtSign { get; set; }

        [NameInMap("orgPayStatus")]
        [Validation(Required=false)]
        public string OrgPayStatus { get; set; }

        [NameInMap("signStatus")]
        [Validation(Required=false)]
        public string SignStatus { get; set; }

        [NameInMap("targetCorpId")]
        [Validation(Required=false)]
        public string TargetCorpId { get; set; }

        [NameInMap("tmcProductDetailList")]
        [Validation(Required=false)]
        public List<SyncBusinessSignInfoRequestTmcProductDetailList> TmcProductDetailList { get; set; }
        public class SyncBusinessSignInfoRequestTmcProductDetailList : TeaModel {
            [NameInMap("gmtOrgPay")]
            [Validation(Required=false)]
            public string GmtOrgPay { get; set; }

            [NameInMap("payType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("product")]
            [Validation(Required=false)]
            public string Product { get; set; }

        }

        [NameInMap("tmcProductList")]
        [Validation(Required=false)]
        public List<SyncBusinessSignInfoRequestTmcProductList> TmcProductList { get; set; }
        public class SyncBusinessSignInfoRequestTmcProductList : TeaModel {
            [NameInMap("productDetailList")]
            [Validation(Required=false)]
            public List<SyncBusinessSignInfoRequestTmcProductListProductDetailList> ProductDetailList { get; set; }
            public class SyncBusinessSignInfoRequestTmcProductListProductDetailList : TeaModel {
                [NameInMap("categoryType")]
                [Validation(Required=false)]
                public string CategoryType { get; set; }

                [NameInMap("gmtOrgPay")]
                [Validation(Required=false)]
                public string GmtOrgPay { get; set; }

                [NameInMap("openStatus")]
                [Validation(Required=false)]
                public bool? OpenStatus { get; set; }

                [NameInMap("payType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("product")]
                [Validation(Required=false)]
                public string Product { get; set; }

            }

            [NameInMap("tmcCorpId")]
            [Validation(Required=false)]
            public string TmcCorpId { get; set; }

        }

    }

}
