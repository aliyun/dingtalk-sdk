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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            [NameInMap("list")]
            [Validation(Required=false)]
            public List<QueryGoodsListResponseBodyResultList> List { get; set; }
            public class QueryGoodsListResponseBodyResultList : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>衣服</para>
                /// </summary>
                [NameInMap("goodsName")]
                [Validation(Required=false)]
                public string GoodsName { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0001</para>
                /// </summary>
                [NameInMap("goodsNo")]
                [Validation(Required=false)]
                public string GoodsNo { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcdse-dse-example</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XXL</para>
                /// </summary>
                [NameInMap("productSpecs")]
                [Validation(Required=false)]
                public string ProductSpecs { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>件</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public long? MaxResults { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
