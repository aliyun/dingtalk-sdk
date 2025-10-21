// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalknotable_1_0.Models
{
    public class ListRecordsRequest : TeaModel {
        [NameInMap("calcFields")]
        [Validation(Required=false)]
        public bool? CalcFields { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public ListRecordsRequestFilter Filter { get; set; }
        public class ListRecordsRequestFilter : TeaModel {
            [NameInMap("combination")]
            [Validation(Required=false)]
            public string Combination { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<ListRecordsRequestFilterConditions> Conditions { get; set; }
            public class ListRecordsRequestFilterConditions : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<object> Value { get; set; }

            }

        }

        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
