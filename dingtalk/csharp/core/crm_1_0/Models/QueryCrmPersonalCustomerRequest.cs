// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryCrmPersonalCustomerRequest : TeaModel {
        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("currentOperatorUserId")]
        [Validation(Required=false)]
        public string CurrentOperatorUserId { get; set; }

        /// <summary>
        /// 分页条数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [NameInMap("queryDsl")]
        [Validation(Required=false)]
        public string QueryDsl { get; set; }

    }

}
