// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryPositionsRequest : TeaModel {
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("inCategoryIds")]
        [Validation(Required=false)]
        public List<string> InCategoryIds { get; set; }

        [NameInMap("inPositionIds")]
        [Validation(Required=false)]
        public List<string> InPositionIds { get; set; }

        [NameInMap("positionName")]
        [Validation(Required=false)]
        public string PositionName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

    }

}
