// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class QueryJobRanksRequest : TeaModel {
        /// <summary>
        /// 职级序列
        /// </summary>
        [NameInMap("rankCategoryId")]
        [Validation(Required=false)]
        public string RankCategoryId { get; set; }

        /// <summary>
        /// 职级编码
        /// </summary>
        [NameInMap("rankCode")]
        [Validation(Required=false)]
        public string RankCode { get; set; }

        /// <summary>
        /// 职级名称
        /// </summary>
        [NameInMap("rankName")]
        [Validation(Required=false)]
        public string RankName { get; set; }

        /// <summary>
        /// 标记当前开始读取的位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// 本次读取的最大数据记录数量
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

    }

}
