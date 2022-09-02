// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SendInteractiveCardResponseBody : TeaModel {
        /// <summary>
        /// 创建卡片结果
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public SendInteractiveCardResponseBodyResult Result { get; set; }
        public class SendInteractiveCardResponseBodyResult : TeaModel {
            /// <summary>
            /// 用于业务方后续查看已读列表的查询key
            /// </summary>
            [NameInMap("processQueryKey")]
            [Validation(Required=false)]
            public string ProcessQueryKey { get; set; }

        }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
