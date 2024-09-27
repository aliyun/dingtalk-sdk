// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class OpenUserSendCardMessageRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cardContent")]
        [Validation(Required=false)]
        public OpenUserSendCardMessageRequestCardContent CardContent { get; set; }
        public class OpenUserSendCardMessageRequestCardContent : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("lastMessage")]
            [Validation(Required=false)]
            public string LastMessage { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("outTrackId")]
            [Validation(Required=false)]
            public string OutTrackId { get; set; }

        }

        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("receiveUserId")]
        [Validation(Required=false)]
        public string ReceiveUserId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
