// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkresident_1_0.Models
{
    public class PagePointHistoryRequest : TeaModel {
        /// <summary>
        /// 结束时间Unix时间戳（不包含），可空
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 是否查询全员圈积分
        /// </summary>
        [NameInMap("isCircle")]
        [Validation(Required=false)]
        public bool? IsCircle { get; set; }

        /// <summary>
        /// 本次读取的最大数据记录数量，最大20
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 用来标记当前开始读取的位置
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 起始时间Unix时间戳，可空
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 用户userid，可空，不传表示查询组织内所有用户的流水数据
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
