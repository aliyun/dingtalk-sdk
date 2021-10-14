// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryPositionsRequest : TeaModel {
        /// <summary>
        /// 职位类别列表
        /// </summary>
        [NameInMap("inCategoryIds")]
        [Validation(Required=false)]
        public List<string> InCategoryIds { get; set; }

        /// <summary>
        /// 职位id列表
        /// </summary>
        [NameInMap("inPositionIds")]
        [Validation(Required=false)]
        public List<string> InPositionIds { get; set; }

        /// <summary>
        /// 职位名称
        /// </summary>
        [NameInMap("positionName")]
        [Validation(Required=false)]
        public string PositionName { get; set; }

        /// <summary>
        /// 一次查询获取记录数
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

    }

}
