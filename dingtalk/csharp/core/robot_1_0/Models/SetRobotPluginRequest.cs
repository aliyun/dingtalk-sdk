// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkrobot_1_0.Models
{
    public class SetRobotPluginRequest : TeaModel {
        [NameInMap("pluginInfoList")]
        [Validation(Required=false)]
        public List<SetRobotPluginRequestPluginInfoList> PluginInfoList { get; set; }
        public class SetRobotPluginRequestPluginInfoList : TeaModel {
            /// <summary>
            /// 快捷入口的图标id
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 手机端快捷入口跳转链接
            /// </summary>
            [NameInMap("mobileUrl")]
            [Validation(Required=false)]
            public string MobileUrl { get; set; }

            /// <summary>
            /// 快捷入口的名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// pc端会话快捷入口跳转链接
            /// </summary>
            [NameInMap("pcUrl")]
            [Validation(Required=false)]
            public string PcUrl { get; set; }

        }

        /// <summary>
        /// 钉钉开放平台后台机器人的robotCode
        /// </summary>
        [NameInMap("robotCode")]
        [Validation(Required=false)]
        public string RobotCode { get; set; }

    }

}
