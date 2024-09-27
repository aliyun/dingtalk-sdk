// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class LoadBizObjectsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{     &quot;Type&quot;: &quot;Item&quot;,     &quot;Name&quot;: &quot;F0000010&quot;,     &quot;Operator&quot;: 2,     &quot;Value&quot;: &quot;0000007&quot; }</para>
        /// </summary>
        [NameInMap("matcherJson")]
        [Validation(Required=false)]
        public string MatcherJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("returnFields")]
        [Validation(Required=false)]
        public List<string> ReturnFields { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0001839bbbbe346bbf496498bb76c44c7eb972</para>
        /// </summary>
        [NameInMap("schemaCode")]
        [Validation(Required=false)]
        public string SchemaCode { get; set; }

        [NameInMap("sortByFields")]
        [Validation(Required=false)]
        public List<LoadBizObjectsRequestSortByFields> SortByFields { get; set; }
        public class LoadBizObjectsRequestSortByFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Ascending</para>
            /// </summary>
            [NameInMap("direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Age</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

        }

    }

}
