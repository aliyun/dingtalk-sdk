// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizObjectsRequest : TeaModel {
        [NameInMap("matcherJson")]
        [Validation(Required=false)]
        public string MatcherJson { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("returnFields")]
        [Validation(Required=false)]
        public List<string> ReturnFields { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

        [NameInMap("sortByFields")]
        [Validation(Required=false)]
        public List<LoadBizObjectsRequestSortByFields> SortByFields { get; set; }
        public class LoadBizObjectsRequestSortByFields : TeaModel {
            [NameInMap("direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

    }

}
