// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class UpdateCardRequest : TeaModel {
        /// <summary>
        /// 卡片实例唯一标识
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// 卡片变量赋值，json结构
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        /// <summary>
        /// 卡片更新群系统通知
        /// </summary>
        [NameInMap("tips")]
        [Validation(Required=false)]
        public UpdateCardRequestTips Tips { get; set; }
        public class UpdateCardRequestTips : TeaModel {
            /// <summary>
            /// 系统通知的群组
            /// </summary>
            [NameInMap("cids")]
            [Validation(Required=false)]
            public string Cids { get; set; }

            /// <summary>
            /// 系统通知内容
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// 发送人
            /// </summary>
            [NameInMap("sender")]
            [Validation(Required=false)]
            public string Sender { get; set; }

        }

    }

}
