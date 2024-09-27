// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryPositionsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>部门id</para>
        /// </summary>
        [NameInMap("deptId")]
        [Validation(Required=false)]
        public long? DeptId { get; set; }

        [NameInMap("inCategoryIds")]
        [Validation(Required=false)]
        public List<string> InCategoryIds { get; set; }

        [NameInMap("inPositionIds")]
        [Validation(Required=false)]
        public List<string> InPositionIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>职位名称</para>
        /// </summary>
        [NameInMap("positionName")]
        [Validation(Required=false)]
        public string PositionName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

    }

}
