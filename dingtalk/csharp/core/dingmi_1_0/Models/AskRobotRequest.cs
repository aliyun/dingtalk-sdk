// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdingmi_1_0.Models
{
    public class AskRobotRequest : TeaModel {
        /// <summary>
        /// 问题
        /// </summary>
        [NameInMap("question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        /// <summary>
        /// 企业corpId
        /// </summary>
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        /// <summary>
        /// 机器人id
        /// </summary>
        [NameInMap("robotAppKey")]
        [Validation(Required=false)]
        public string RobotAppKey { get; set; }

        /// <summary>
        /// sessionId(非必传)
        /// </summary>
        [NameInMap("sessionUuid")]
        [Validation(Required=false)]
        public string SessionUuid { get; set; }

        /// <summary>
        /// suiteKey
        /// </summary>
        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

    }

}
