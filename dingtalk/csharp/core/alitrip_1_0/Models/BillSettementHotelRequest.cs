// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkalitrip_1_0.Models
{
    public class BillSettementHotelRequest : TeaModel {
        /// <summary>
        /// 类目：机酒火车 1：机票； 2：酒店； 4：用车 6：商旅火车票
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public long? Category { get; set; }

        /// <summary>
        /// 第三方企业
        /// </summary>
        [NameInMap("corpId")]
        [Validation(Required=false)]
        public string CorpId { get; set; }

        /// <summary>
        /// 页数，从1开始
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 每页数据量，默认100，最高500
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 记账更新结束日期
        /// </summary>
        [NameInMap("periodEnd")]
        [Validation(Required=false)]
        public string PeriodEnd { get; set; }

        /// <summary>
        /// 记账更新开始日期
        /// </summary>
        [NameInMap("periodStart")]
        [Validation(Required=false)]
        public string PeriodStart { get; set; }

    }

}
