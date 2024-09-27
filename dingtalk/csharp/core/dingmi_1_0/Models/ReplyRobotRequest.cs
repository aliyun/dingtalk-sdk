// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class ReplyRobotRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;bizParamMap&quot;:{&quot;proxySessionId&quot;:&quot;DINGTALK_RYnVfayNAe_4000006001201145&quot;},&quot;msgType&quot;:&quot;text&quot;,&quot;text&quot;:&quot;测试回复机器人消息&quot;}</para>
        /// </summary>
        [NameInMap("proxyMessageStr")]
        [Validation(Required=false)]
        public string ProxyMessageStr { get; set; }

    }

}
