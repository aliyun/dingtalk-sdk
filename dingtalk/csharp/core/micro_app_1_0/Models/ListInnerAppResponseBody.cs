// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class ListInnerAppResponseBody : TeaModel {
        /// <summary>
        /// 应用列表
        /// </summary>
        [NameInMap("appList")]
        [Validation(Required=false)]
        public List<ListInnerAppResponseBodyAppList> AppList { get; set; }
        public class ListInnerAppResponseBodyAppList : TeaModel {
            /// <summary>
            /// 应用id
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public long? AgentId { get; set; }

            /// <summary>
            /// 应用描述
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// 应用移动端首页地址
            /// </summary>
            [NameInMap("homepageLink")]
            [Validation(Required=false)]
            public string HomepageLink { get; set; }

            /// <summary>
            /// 应用图标
            /// </summary>
            [NameInMap("icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// 应用名称
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 应用管理后台地址
            /// </summary>
            [NameInMap("ompLink")]
            [Validation(Required=false)]
            public string OmpLink { get; set; }

            /// <summary>
            /// 应用PC端首页地址
            /// </summary>
            [NameInMap("pcHomepageLink")]
            [Validation(Required=false)]
            public string PcHomepageLink { get; set; }

        }

    }

}
