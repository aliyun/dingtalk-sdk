// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchAllTasksByTqlRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DXF1ZXJ5QW5kRmV0Y2gBAAAAAAKC9p4WVjNKbUstaldRX3lOOHNBbElzcjA5Zw==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>isDone = false</para>
        /// </summary>
        [NameInMap("tql")]
        [Validation(Required=false)]
        public string Tql { get; set; }

    }

}
