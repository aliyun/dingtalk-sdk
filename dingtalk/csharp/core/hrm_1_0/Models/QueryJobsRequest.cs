// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryJobsRequest : TeaModel {
        /// <summary>
        /// 职务名称
        /// </summary>
        [NameInMap("jobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

    }

}
