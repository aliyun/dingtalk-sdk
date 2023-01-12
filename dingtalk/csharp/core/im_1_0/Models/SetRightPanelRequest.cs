// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class SetRightPanelRequest : TeaModel {
        /// <summary>
        /// 场景群的openConversationId
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// 是否允许群成员关闭侧边栏 true-允许 false-不允许
        /// </summary>
        [NameInMap("rightPanelClosePermitted")]
        [Validation(Required=false)]
        public bool? RightPanelClosePermitted { get; set; }

        /// <summary>
        /// 侧边栏打开状态 1-开启 0-关闭
        /// </summary>
        [NameInMap("rightPanelOpenStatus")]
        [Validation(Required=false)]
        public int? RightPanelOpenStatus { get; set; }

        /// <summary>
        /// 标题栏文案
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 网页侧边栏属性配置
        /// </summary>
        [NameInMap("webWndParams")]
        [Validation(Required=false)]
        public SetRightPanelRequestWebWndParams WebWndParams { get; set; }
        public class SetRightPanelRequestWebWndParams : TeaModel {
            /// <summary>
            /// 侧边栏URL
            /// </summary>
            [NameInMap("targetURL")]
            [Validation(Required=false)]
            public string TargetURL { get; set; }

        }

        /// <summary>
        /// 侧边栏
        /// </summary>
        [NameInMap("width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
