// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdevicemng_1_0.Models
{
    public class UpdateCardRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("cardData")]
        [Validation(Required=false)]
        public string CardData { get; set; }

        [NameInMap("tips")]
        [Validation(Required=false)]
        public UpdateCardRequestTips Tips { get; set; }
        public class UpdateCardRequestTips : TeaModel {
            [NameInMap("cids")]
            [Validation(Required=false)]
            public string Cids { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("sender")]
            [Validation(Required=false)]
            public string Sender { get; set; }

        }

    }

}
