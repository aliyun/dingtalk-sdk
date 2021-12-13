// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizObjectsRequest : TeaModel {
        /// <summary>
        /// json格式的动态条件过滤器参数
        /// </summary>
        [NameInMap("matcherJson")]
        [Validation(Required=false)]
        public string MatcherJson { get; set; }

        /// <summary>
        /// 分页页码
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 分页页大小。限制在1~500
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 返回的字段.仅支持传入主表的字段
        /// </summary>
        [NameInMap("returnFields")]
        [Validation(Required=false)]
        public List<string> ReturnFields { get; set; }

        /// <summary>
        /// 表单编码
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

        /// <summary>
        /// 排序字段结构数组
        /// </summary>
        [NameInMap("sortByFields")]
        [Validation(Required=false)]
        public List<LoadBizObjectsRequestSortByFields> SortByFields { get; set; }
        public class LoadBizObjectsRequestSortByFields : TeaModel {
            /// <summary>
            /// 排序字段名
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// 排序方向。Ascending=升序，Descending=降序
            /// </summary>
            [NameInMap("direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

        }

    }

}
