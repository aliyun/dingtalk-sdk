// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class QueueNotifyRequest : TeaModel {
        /// <summary>
        /// 预计等待时间，单位：分钟
        /// </summary>
        [NameInMap("estimateWaitMin")]
        [Validation(Required=false)]
        public long? EstimateWaitMin { get; set; }

        /// <summary>
        /// 开放团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 当前排队次序
        /// </summary>
        [NameInMap("queuePlace")]
        [Validation(Required=false)]
        public long? QueuePlace { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [NameInMap("serviceToken")]
        [Validation(Required=false)]
        public string ServiceToken { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [NameInMap("targetChannel")]
        [Validation(Required=false)]
        public string TargetChannel { get; set; }

        /// <summary>
        /// 展示文案
        /// </summary>
        [NameInMap("tips")]
        [Validation(Required=false)]
        public string Tips { get; set; }

        /// <summary>
        /// DT端定义的访客token
        /// </summary>
        [NameInMap("visitorToken")]
        [Validation(Required=false)]
        public string VisitorToken { get; set; }

    }

}
