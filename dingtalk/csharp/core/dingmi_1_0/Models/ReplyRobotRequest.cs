// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class ReplyRobotRequest : TeaModel {
        /// <summary>
        /// 企业corpId
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// 回复消息内容的json string
        /// </summary>
        [NameInMap("proxyMessageStr")]
        [Validation(Required=false)]
        public string ProxyMessageStr { get; set; }

    }

}
