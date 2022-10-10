// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class PreDialRequest : TeaModel {
        /// <summary>
        /// 通话发起人的userId
        /// </summary>
        [NameInMap("callerUserId")]
        [Validation(Required=false)]
        public string CallerUserId { get; set; }

        /// <summary>
        /// 通话接收人的userId
        /// </summary>
        [NameInMap("receiverUserId")]
        [Validation(Required=false)]
        public string ReceiverUserId { get; set; }

        /// <summary>
        /// 设备sn码
        /// </summary>
        [NameInMap("sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
