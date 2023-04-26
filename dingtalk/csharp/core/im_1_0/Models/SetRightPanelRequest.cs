// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SetRightPanelRequest : TeaModel {
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("rightPanelClosePermitted")]
        [Validation(Required=false)]
        public bool? RightPanelClosePermitted { get; set; }

        [NameInMap("rightPanelOpenStatus")]
        [Validation(Required=false)]
        public int? RightPanelOpenStatus { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("webWndParams")]
        [Validation(Required=false)]
        public SetRightPanelRequestWebWndParams WebWndParams { get; set; }
        public class SetRightPanelRequestWebWndParams : TeaModel {
            [NameInMap("targetURL")]
            [Validation(Required=false)]
            public string TargetURL { get; set; }

        }

        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
