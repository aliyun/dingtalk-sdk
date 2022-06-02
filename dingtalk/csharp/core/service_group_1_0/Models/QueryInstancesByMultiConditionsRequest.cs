// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryInstancesByMultiConditionsRequest : TeaModel {
        /// <summary>
        /// 表单CODE
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// 游标位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 检索条件
        /// </summary>
        [NameInMap("searchFields")]
        [Validation(Required=false)]
        public string SearchFields { get; set; }

        /// <summary>
        /// 排序条件
        /// </summary>
        [NameInMap("sortFields")]
        [Validation(Required=false)]
        public List<QueryInstancesByMultiConditionsRequestSortFields> SortFields { get; set; }
        public class QueryInstancesByMultiConditionsRequestSortFields : TeaModel {
            /// <summary>
            /// 排序字段
            /// </summary>
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            /// <summary>
            /// 排序方式
            /// </summary>
            [NameInMap("sortBy")]
            [Validation(Required=false)]
            public string SortBy { get; set; }

        }

    }

}
