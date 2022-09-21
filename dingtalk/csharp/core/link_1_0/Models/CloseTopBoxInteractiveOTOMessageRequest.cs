// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class CloseTopBoxInteractiveOTOMessageRequest : TeaModel {
        /// <summary>
        /// 卡片参数
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public CloseTopBoxInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class CloseTopBoxInteractiveOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// 唯一标识一张卡片的ID，卡片幂等ID
            /// </summary>
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            /// <summary>
            /// 卡片模板 ID
            /// </summary>
            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            /// <summary>
            /// 用户 userId
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
