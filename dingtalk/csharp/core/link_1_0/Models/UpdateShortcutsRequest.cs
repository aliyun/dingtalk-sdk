// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklink_1_0.Models
{
    public class UpdateShortcutsRequest : TeaModel {
        /// <summary>
        /// 配置详情
        /// </summary>
        [NameInMap("details")]
        [Validation(Required=false)]
        public List<UpdateShortcutsRequestDetails> Details { get; set; }
        public class UpdateShortcutsRequestDetails : TeaModel {
            /// <summary>
            /// 用户点快捷入口时的跳转链接，此参数与callbackKey二选一。
            /// </summary>
            [NameInMap("actionUrl")]
            [Validation(Required=false)]
            public string ActionUrl { get; set; }

            /// <summary>
            /// 快捷入口点击回调Key,可通过回调注册接口获得。此参数与actionUrl二选一。
            /// </summary>
            [NameInMap("callbackKey")]
            [Validation(Required=false)]
            public string CallbackKey { get; set; }

            /// <summary>
            /// windows侧边栏图标的unicode
            /// </summary>
            [NameInMap("iconFont")]
            [Validation(Required=false)]
            public string IconFont { get; set; }

            /// <summary>
            /// 移动端图标
            /// </summary>
            [NameInMap("iconMediaId")]
            [Validation(Required=false)]
            public string IconMediaId { get; set; }

            /// <summary>
            /// 插件唯一标识
            /// </summary>
            [NameInMap("shortcutId")]
            [Validation(Required=false)]
            public string ShortcutId { get; set; }

            /// <summary>
            /// 适配mac端侧边栏图标的mediaId
            /// </summary>
            [NameInMap("slideIconMediaId")]
            [Validation(Required=false)]
            public string SlideIconMediaId { get; set; }

            /// <summary>
            /// 插件标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 会话id
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
