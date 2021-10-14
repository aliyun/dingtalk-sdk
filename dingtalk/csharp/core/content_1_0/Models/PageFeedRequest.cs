// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontent_1_0.Models
{
    public class PageFeedRequest : TeaModel {
        /// <summary>
        /// 内容Id，如果传入该参数，表示仅筛选内容Id出现在本列表中的内容
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<string> Body { get; set; }

        /// <summary>
        /// 分页参数：页面展示数量
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 入驻账号Id(请联系钉钉接口同学获取)
        /// </summary>
        [NameInMap("mcnId")]
        [Validation(Required=false)]
        public string McnId { get; set; }

        /// <summary>
        /// 分页参数：起始位置，初始值应为0，后续传入返回值中的nextCursor字段中的值
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

    }

}
