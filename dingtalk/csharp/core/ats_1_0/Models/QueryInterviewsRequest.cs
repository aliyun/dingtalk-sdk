// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class QueryInterviewsRequest : TeaModel {
        /// <summary>
        /// 业务标识
        /// </summary>
        [NameInMap("bizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 面试开始时间的查询起始时间（单位：毫秒）
        /// </summary>
        [NameInMap("startTimeBeginMillis")]
        [Validation(Required=false)]
        public long? StartTimeBeginMillis { get; set; }

        /// <summary>
        /// 面试开始时间的查询结束时间（单位：毫秒）
        /// </summary>
        [NameInMap("startTimeEndMillis")]
        [Validation(Required=false)]
        public long? StartTimeEndMillis { get; set; }

        /// <summary>
        /// 候选人标识
        /// </summary>
        [NameInMap("candidateId")]
        [Validation(Required=false)]
        public string CandidateId { get; set; }

        /// <summary>
        /// 分页游标，首次调用传空
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

    }

}
