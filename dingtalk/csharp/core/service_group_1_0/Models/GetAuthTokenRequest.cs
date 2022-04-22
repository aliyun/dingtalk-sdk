// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class GetAuthTokenRequest : TeaModel {
        /// <summary>
        /// 渠道DT/LINKS
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// token有效时间（秒）-可不传
        /// </summary>
        [NameInMap("effectiveTime")]
        [Validation(Required=false)]
        public long? EffectiveTime { get; set; }

        /// <summary>
        /// 团队ID
        /// </summary>
        [NameInMap("openTeamId")]
        [Validation(Required=false)]
        public string OpenTeamId { get; set; }

        /// <summary>
        /// 小二id
        /// </summary>
        [NameInMap("serverId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// 小二名称
        /// </summary>
        [NameInMap("serverName")]
        [Validation(Required=false)]
        public string ServerName { get; set; }

    }

}
