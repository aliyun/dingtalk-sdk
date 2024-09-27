// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class UpdateInteractiveOTOMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public UpdateInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class UpdateInteractiveOTOMessageRequestDetail : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>service-card-202208240001</para>
            /// </summary>
            [NameInMap("cardBizId")]
            [Validation(Required=false)]
            public string CardBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;like&quot;:1}</para>
            /// </summary>
            [NameInMap("cardData")]
            [Validation(Required=false)]
            public string CardData { get; set; }

            [NameInMap("updateOptions")]
            [Validation(Required=false)]
            public UpdateInteractiveOTOMessageRequestDetailUpdateOptions UpdateOptions { get; set; }
            public class UpdateInteractiveOTOMessageRequestDetailUpdateOptions : TeaModel {
                [NameInMap("updateCardDataByKey")]
                [Validation(Required=false)]
                public bool? UpdateCardDataByKey { get; set; }

                [NameInMap("updatePrivateDataByKey")]
                [Validation(Required=false)]
                public bool? UpdatePrivateDataByKey { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;userI&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("userIdPrivateDataMap")]
            [Validation(Required=false)]
            public string UserIdPrivateDataMap { get; set; }

        }

    }

}
