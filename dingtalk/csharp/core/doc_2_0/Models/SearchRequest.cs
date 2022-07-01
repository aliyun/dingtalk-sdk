// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SearchRequest : TeaModel {
        /// <summary>
        /// 节点搜索请求，和空间搜索请求二选一必填。
        /// </summary>
        [NameInMap("dentryRequest")]
        [Validation(Required=false)]
        public SearchRequestDentryRequest DentryRequest { get; set; }
        public class SearchRequestDentryRequest : TeaModel {
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("searchFileType")]
            [Validation(Required=false)]
            public int? SearchFileType { get; set; }
            [NameInMap("spaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }
        };

        /// <summary>
        ///  搜索关键词。
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// 操作人unionId。
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 空间搜索请求，和节点搜索请求二选一必填。
        /// </summary>
        [NameInMap("spaceRequest")]
        [Validation(Required=false)]
        public SearchRequestSpaceRequest SpaceRequest { get; set; }
        public class SearchRequestSpaceRequest : TeaModel {
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

    }

}
