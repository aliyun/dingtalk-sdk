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
            [NameInMap("callbackKey")]
            [Validation(Required=false)]
            public string CallbackKey { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("newCard")]
            [Validation(Required=false)]
            public bool? NewCard { get; set; }

            [NameInMap("outTraceId")]
            [Validation(Required=false)]
            public string OutTraceId { get; set; }

            [NameInMap("sceneCardCode")]
            [Validation(Required=false)]
            public string SceneCardCode { get; set; }

            [NameInMap("sceneScope")]
            [Validation(Required=false)]
            public long? SceneScope { get; set; }

            [NameInMap("sendNow")]
            [Validation(Required=false)]
            public bool? SendNow { get; set; }

        }

    }

}
