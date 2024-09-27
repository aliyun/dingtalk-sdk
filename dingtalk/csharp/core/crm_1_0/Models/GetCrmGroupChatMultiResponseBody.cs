// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcrm_1_0.Models
{
    public class GetCrmGroupChatMultiResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetCrmGroupChatMultiResponseBodyResult> Result { get; set; }
        public class GetCrmGroupChatMultiResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1642078998377</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://static/xx.com/xx.jpg">https://static/xx.com/xx.jpg</a></para>
            /// </summary>
            [NameInMap("iconUrl")]
            [Validation(Required=false)]
            public string IconUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("memberCount")]
            [Validation(Required=false)]
            public int? MemberCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>营销1群</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xx==</para>
            /// </summary>
            [NameInMap("openConversationId")]
            [Validation(Required=false)]
            public string OpenConversationId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxa==</para>
            /// </summary>
            [NameInMap("openGroupSetId")]
            [Validation(Required=false)]
            public string OpenGroupSetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>axaf12</para>
            /// </summary>
            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>XX</para>
            /// </summary>
            [NameInMap("ownerUserName")]
            [Validation(Required=false)]
            public string OwnerUserName { get; set; }

        }

    }

}
