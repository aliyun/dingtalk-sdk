// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class SendInteractiveOTOMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public SendInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class SendInteractiveOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://www.youurl.com/callback/card">https://www.youurl.com/callback/card</a></para>
            /// </summary>
            [NameInMap("callbackUrl")]
            [Validation(Required=false)]
            public string CallbackUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-card-20220824-001</para>
            /// </summary>
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cardData")]
            [Validation(Required=false)]
            public string CardData { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3erkfi-42b0-4c83-bc56-ffhssde43</para>
            /// </summary>
            [NameInMap("cardTemplateId")]
            [Validation(Required=false)]
            public string CardTemplateId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user0001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;user001&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("userIdPrivateDataMap")]
            [Validation(Required=false)]
            public string UserIdPrivateDataMap { get; set; }

        }

    }

}
