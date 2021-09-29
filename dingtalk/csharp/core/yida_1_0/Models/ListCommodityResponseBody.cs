// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class ListCommodityResponseBody : TeaModel {
        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// commodityVOList
        /// </summary>
        [NameInMap("commodityVOList")]
        [Validation(Required=false)]
        public List<ListCommodityResponseBodyCommodityVOList> CommodityVOList { get; set; }
        public class ListCommodityResponseBodyCommodityVOList : TeaModel {
            /// <summary>
            /// instanceId
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// buyDate
            /// </summary>
            [NameInMap("buyDateGMT")]
            [Validation(Required=false)]
            public string BuyDateGMT { get; set; }

            /// <summary>
            /// expireDate
            /// </summary>
            [NameInMap("expireDateGMT")]
            [Validation(Required=false)]
            public string ExpireDateGMT { get; set; }

            /// <summary>
            /// activationCode
            /// </summary>
            [NameInMap("activationCode")]
            [Validation(Required=false)]
            public string ActivationCode { get; set; }

            /// <summary>
            /// accountNum
            /// </summary>
            [NameInMap("accountNumber")]
            [Validation(Required=false)]
            public int? AccountNumber { get; set; }

            /// <summary>
            /// accountDistributionNumber
            /// </summary>
            [NameInMap("accountDistributionNumber")]
            [Validation(Required=false)]
            public int? AccountDistributionNumber { get; set; }

            /// <summary>
            /// version
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// status
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// 当前第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
