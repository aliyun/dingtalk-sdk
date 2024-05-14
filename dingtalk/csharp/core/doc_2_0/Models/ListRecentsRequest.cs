// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class ListRecentsRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public ListRecentsRequestParam Param { get; set; }
        public class ListRecentsRequestParam : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("fileTypes")]
            [Validation(Required=false)]
            public List<int?> FileTypes { get; set; }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("operateTypes")]
            [Validation(Required=false)]
            public List<int?> OperateTypes { get; set; }

        }

    }

}
