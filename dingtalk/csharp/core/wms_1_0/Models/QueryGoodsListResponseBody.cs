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
            /// <summary>
            /// 下次获取数据的游标
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryGoodsListResponseBodyResultList> List { get; set; }
            public class QueryGoodsListResponseBodyResultList : TeaModel {
                /// <summary>
                /// 物料名称
                /// </summary>
                [NameInMap("goodsName")]
                [Validation(Required=false)]
                public string GoodsName { get; set; }

                /// <summary>
                /// 物料编号
                /// </summary>
                [NameInMap("goodsNo")]
                [Validation(Required=false)]
                public string GoodsNo { get; set; }

                /// <summary>
                /// 物料ID
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// 规格
                /// </summary>
                [NameInMap("productSpecs")]
                [Validation(Required=false)]
                public string ProductSpecs { get; set; }

                /// <summary>
                /// 计量单位
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// 总数
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// 下次获取数据的游标
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
