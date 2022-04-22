// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListAuditLogRequest : TeaModel {
        /// <summary>
        /// 操作日志截止时间，unix时间戳，单位ms
        /// </summary>
        [NameInMap("endDate")]
        [Validation(Required=false)]
        public long? EndDate { get; set; }

        /// <summary>
        /// 操作记录文件id，作为分页偏移量，与nextGmtCreate一起使用，返回记录的bizId为nextBizId且gmtCreate为nextGmtCreate之后的操作列表，分页查询获取下一页时，传最后一条记录的bizId和gmtCreate。
        /// </summary>
        [NameInMap("nextBizId")]
        [Validation(Required=false)]
        public long? NextBizId { get; set; }

        /// <summary>
        /// 操作记录生成时间，作为分页偏移量，分页查询时必传，unix时间戳，单位ms
        /// </summary>
        [NameInMap("nextGmtCreate")]
        [Validation(Required=false)]
        public long? NextGmtCreate { get; set; }

        /// <summary>
        /// 操作列表长度，最大500
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 操作日志起始时间，unix时间戳，单位ms
        /// </summary>
        [NameInMap("startDate")]
        [Validation(Required=false)]
        public long? StartDate { get; set; }

    }

}
