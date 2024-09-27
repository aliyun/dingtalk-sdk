// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class UpdateShortcutsRequest : TeaModel {
        [NameInMap("details")]
        [Validation(Required=false)]
        public List<UpdateShortcutsRequestDetails> Details { get; set; }
        public class UpdateShortcutsRequestDetails : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dingtalk.com">https://dingtalk.com</a></para>
            /// </summary>
            [NameInMap("actionUrl")]
            [Validation(Required=false)]
            public string ActionUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>033bd94b1168d7e4f0d644c3c95e35bf</para>
            /// </summary>
            [NameInMap("callbackKey")]
            [Validation(Required=false)]
            public string CallbackKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>e73e</para>
            /// </summary>
            [NameInMap("iconFont")]
            [Validation(Required=false)]
            public string IconFont { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>@lADPDg7mWPzw0i_NArzNArw</para>
            /// </summary>
            [NameInMap("iconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test123456</para>
            /// </summary>
            [NameInMap("shortcutId")]
            [Validation(Required=false)]
            public string ShortcutId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>@lADPDg7mWPzw0i_NArzNArw</para>
            /// </summary>
            [NameInMap("slideIconMediaId")]
            [Validation(Required=false)]
            public string SlideIconMediaId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sid001234</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idzb26bxl64vqx2keyi</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
