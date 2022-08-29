// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class GetRecognizeRecordsRequest : TeaModel {
        /// <summary>
        /// 应用唯一标识
        /// </summary>
        [NameInMap("agentId")]
        [Validation(Required=false)]
        public long? AgentId { get; set; }

        /// <summary>
        /// 人脸对比结果 1-成功 2-失败
        /// </summary>
        [NameInMap("faceCompareResult")]
        [Validation(Required=false)]
        public int? FaceCompareResult { get; set; }

        /// <summary>
        /// 记录开始时间(毫秒时间戳)
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// 一页最大值（最大50）
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 查询数据的起始位置，0表示从头开始。
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        /// <summary>
        /// 记录结束时间(毫秒时间戳)
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        /// <summary>
        /// 员工userIds
        /// </summary>
        [NameInMap("userIds")]
        [Validation(Required=false)]
        public List<string> UserIds { get; set; }

    }

}
