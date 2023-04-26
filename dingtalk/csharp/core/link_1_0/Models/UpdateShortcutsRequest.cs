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
            [NameInMap("actionUrl")]
            [Validation(Required=false)]
            public string ActionUrl { get; set; }

            [NameInMap("callbackKey")]
            [Validation(Required=false)]
            public string CallbackKey { get; set; }

            [NameInMap("iconFont")]
            [Validation(Required=false)]
            public string IconFont { get; set; }

            [NameInMap("iconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }

            [NameInMap("shortcutId")]
            [Validation(Required=false)]
            public string ShortcutId { get; set; }

            [NameInMap("slideIconMediaId")]
            [Validation(Required=false)]
            public string SlideIconMediaId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
