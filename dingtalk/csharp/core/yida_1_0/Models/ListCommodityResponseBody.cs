// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListCommodityResponseBody : TeaModel {
        [NameInMap("commodityVOList")]
        [Validation(Required=false)]
        public List<ListCommodityResponseBodyCommodityVOList> CommodityVOList { get; set; }
        public class ListCommodityResponseBodyCommodityVOList : TeaModel {
            [NameInMap("accountDistributionNumber")]
            [Validation(Required=false)]
            public int? AccountDistributionNumber { get; set; }

            [NameInMap("accountNumber")]
            [Validation(Required=false)]
            public int? AccountNumber { get; set; }

            [NameInMap("activationCode")]
            [Validation(Required=false)]
            public string ActivationCode { get; set; }

            [NameInMap("buyDateGMT")]
            [Validation(Required=false)]
            public string BuyDateGMT { get; set; }

            [NameInMap("expireDateGMT")]
            [Validation(Required=false)]
            public string ExpireDateGMT { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
