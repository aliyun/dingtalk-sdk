// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SetRightPanelRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("rightPanelClosePermitted")]
        [Validation(Required=false)]
        public bool? RightPanelClosePermitted { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("rightPanelOpenStatus")]
        [Validation(Required=false)]
        public int? RightPanelOpenStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("webWndParams")]
        [Validation(Required=false)]
        public SetRightPanelRequestWebWndParams WebWndParams { get; set; }
        public class SetRightPanelRequestWebWndParams : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("targetURL")]
            [Validation(Required=false)]
            public string TargetURL { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
