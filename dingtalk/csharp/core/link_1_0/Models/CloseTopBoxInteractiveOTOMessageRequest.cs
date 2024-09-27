// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class CloseTopBoxInteractiveOTOMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("detail")]
        [Validation(Required=false)]
        public CloseTopBoxInteractiveOTOMessageRequestDetail Detail { get; set; }
        public class CloseTopBoxInteractiveOTOMessageRequestDetail : TeaModel {
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
            /// <para>user001</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
