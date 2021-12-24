// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class QueryCrmGroupChatsRequest : TeaModel {
        /// <summary>
        /// 每页返回的结果集个数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 第一页不传，下一页传入上一页返回的nextToken
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 查询DSL
        /// </summary>
        [NameInMap("queryDsl")]
        [Validation(Required=false)]
        public string QueryDsl { get; set; }

        /// <summary>
        /// 关系类型
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

    }

}
