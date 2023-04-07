// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class SaveWhiteAppRequest : TeaModel {
        /// <summary>
        /// 微应用白名单AgentID
        /// </summary>
        [NameInMap("agentIdList")]
        [Validation(Required=false)]
        public List<long?> AgentIdList { get; set; }

        /// <summary>
        /// 操作符
        /// </summary>
        [NameInMap("operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

    }

}
