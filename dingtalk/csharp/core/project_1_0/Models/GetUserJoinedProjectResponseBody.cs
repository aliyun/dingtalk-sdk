// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class GetUserJoinedProjectResponseBody : TeaModel {
        /// <summary>
        /// 分页标。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 项目 ID 列表。
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<string> Result { get; set; }

        /// <summary>
        /// 总数。
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
