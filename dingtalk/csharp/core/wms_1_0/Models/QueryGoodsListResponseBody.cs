// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkwms_1_0.Models
{
    public class QueryGoodsListResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryGoodsListResponseBodyResult Result { get; set; }
        public class QueryGoodsListResponseBodyResult : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryGoodsListResponseBodyResultList> List { get; set; }
            public class QueryGoodsListResponseBodyResultList : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("goodsName")]
                [Validation(Required=false)]
                public string GoodsName { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("goodsNo")]
                [Validation(Required=false)]
                public string GoodsNo { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("productSpecs")]
                [Validation(Required=false)]
                public string ProductSpecs { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
