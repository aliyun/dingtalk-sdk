// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchOranizationCustomfieldRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>60a2187eb72xxxxxxx</para>
        /// </summary>
        [NameInMap("customFieldIds")]
        [Validation(Required=false)]
        public string CustomFieldIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60a2187eb72xxxxxxx</para>
        /// </summary>
        [NameInMap("instanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>f279e812xxxxxx</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60a2187eb72xxxxxxx,60a2187eb72xxxxxxx</para>
        /// </summary>
        [NameInMap("projectIds")]
        [Validation(Required=false)]
        public string ProjectIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>自定义字段1</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
