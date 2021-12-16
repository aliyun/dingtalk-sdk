// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwms_1_0.Models
{
    public class QueryGoodsListResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryGoodsListResponseBodyResult Result { get; set; }
        public class QueryGoodsListResponseBodyResult : TeaModel {
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }
            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryGoodsListResponseBodyResultList> List { get; set; }
            public class QueryGoodsListResponseBodyResultList : TeaModel {
                public string InstanceId { get; set; }
                public string GoodsNo { get; set; }
                public string GoodsName { get; set; }
                public string Unit { get; set; }
                public string ProductSpecs { get; set; }
            }
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
