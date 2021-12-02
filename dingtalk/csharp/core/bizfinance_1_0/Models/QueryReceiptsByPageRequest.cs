// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptsByPageRequest : TeaModel {
        /// <summary>
        /// 检索结束时间，默认当前时间，离开始时间最长不超过180天
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 数据模型id
        /// </summary>
        [NameInMap("modelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        /// <summary>
        /// 分页，从1开始
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页大小，默认10，最大100
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 检索开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 检索排序时间类型：创建时间(gmt_create)，更新时间(gmt_modified)
        /// </summary>
        [NameInMap("timeFilterField")]
        [Validation(Required=false)]
        public string TimeFilterField { get; set; }

    }

}
