// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkservice_group_1_0.Models
{
    public class ConversationCreatedNotifyResponseBody : TeaModel {
        /// <summary>
        /// dingOpenErrcode
        /// </summary>
        [NameInMap("dingOpenErrcode")]
        [Validation(Required=false)]
        public int? DingOpenErrcode { get; set; }

        /// <summary>
        /// errorMsg
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 回调是否执行成功
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        /// <summary>
        /// 回调是否请求成
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
