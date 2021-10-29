// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0.Models
{
    public class QueryBatchTradeDetailListRequest : TeaModel {
        /// <summary>
        /// 外部商户批次号
        /// </summary>
        [NameInMap("outBatchNo")]
        [Validation(Required=false)]
        public string OutBatchNo { get; set; }

        /// <summary>
        /// 当前页数
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
