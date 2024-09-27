// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueryInstancesByMultiConditionsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DING_CUSTOMER</para>
        /// </summary>
        [NameInMap("formCode")]
        [Validation(Required=false)]
        public string FormCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>888**</para>
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[     {         &quot;fieldCode&quot;:&quot;contact_name&quot;,         &quot;fieldOperatorType&quot;:&quot;like&quot;,         &quot;value&quot;:&quot;测试api&quot;     } ]</para>
        /// </summary>
        [NameInMap("searchFields")]
        [Validation(Required=false)]
        public string SearchFields { get; set; }

        [NameInMap("sortFields")]
        [Validation(Required=false)]
        public List<QueryInstancesByMultiConditionsRequestSortFields> SortFields { get; set; }
        public class QueryInstancesByMultiConditionsRequestSortFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>gmt_create</para>
            /// </summary>
            [NameInMap("fieldCode")]
            [Validation(Required=false)]
            public string FieldCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>asc升序；desc降序</para>
            /// </summary>
            [NameInMap("sortBy")]
            [Validation(Required=false)]
            public string SortBy { get; set; }

        }

    }

}
