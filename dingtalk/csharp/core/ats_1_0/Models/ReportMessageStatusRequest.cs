// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkats_1_0.Models
{
    public class ReportMessageStatusRequest : TeaModel {
        /// <summary>
        /// 渠道标识。
        /// </summary>
        [NameInMap("channel")]
        [Validation(Required=false)]
        public string Channel { get; set; }

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息描述。
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 消息ID。
        /// </summary>
        [NameInMap("messageId")]
        [Validation(Required=false)]
        public string MessageId { get; set; }

    }

}
