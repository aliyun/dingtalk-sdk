// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_1_0.Models
{
    public class QueryReceiptForInvoiceRequest : TeaModel {
        /// <summary>
        /// 发票状态筛选列表 applied 已生成、unapplied 未生成 、 ignore 已忽略
        /// </summary>
        [NameInMap("applyStatusList")]
        [Validation(Required=false)]
        public List<string> ApplyStatusList { get; set; }

        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 分页参数，从1 开始
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页参数，每页查询个数
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// 单据状态筛选条件列表，审批中、已通过 RUNNGIN、COMPLETED
        /// </summary>
        [NameInMap("receiptStatusList")]
        [Validation(Required=false)]
        public List<string> ReceiptStatusList { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 单据标题
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}