// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class BatchSendOTOResponseBody : TeaModel {
        /// <summary>
        /// 消息id
        /// </summary>
        [NameInMap("processQueryKey")]
        [Validation(Required=false)]
        public string ProcessQueryKey { get; set; }

        /// <summary>
        /// 无效的用户userId列表
        /// </summary>
        [NameInMap("invalidStaffIdList")]
        [Validation(Required=false)]
        public List<string> InvalidStaffIdList { get; set; }

        /// <summary>
        /// 推送频繁，被限流的用户userId列表
        /// </summary>
        [NameInMap("flowControlledStaffIdList")]
        [Validation(Required=false)]
        public List<string> FlowControlledStaffIdList { get; set; }

    }

}
