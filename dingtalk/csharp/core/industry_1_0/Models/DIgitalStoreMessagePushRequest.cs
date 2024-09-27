// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DIgitalStoreMessagePushRequest : TeaModel {
        [NameInMap("messageDataList")]
        [Validation(Required=false)]
        public List<DIgitalStoreMessagePushRequestMessageDataList> MessageDataList { get; set; }
        public class DIgitalStoreMessagePushRequestMessageDataList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxcallback</para>
            /// </summary>
            [NameInMap("callbackKey")]
            [Validation(Required=false)]
            public string CallbackKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("newCard")]
            [Validation(Required=false)]
            public bool? NewCard { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ysn138dh1712dsa</para>
            /// </summary>
            [NameInMap("outTraceId")]
            [Validation(Required=false)]
            public string OutTraceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>StoreOrder</para>
            /// </summary>
            [NameInMap("sceneCardCode")]
            [Validation(Required=false)]
            public string SceneCardCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>54774321</para>
            /// </summary>
            [NameInMap("sceneScope")]
            [Validation(Required=false)]
            public long? SceneScope { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("sendNow")]
            [Validation(Required=false)]
            public bool? SendNow { get; set; }

        }

    }

}
