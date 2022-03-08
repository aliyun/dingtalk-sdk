// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetAppsResponseBody : TeaModel {
        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAppsResponseBodyData> Data { get; set; }
        public class GetAppsResponseBodyData : TeaModel {
            /// <summary>
            /// 应用编码
            /// </summary>
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            /// <summary>
            /// 应用的来源类型。Custom=自开发的、Installed=安装的
            /// </summary>
            [NameInMap("appSource")]
            [Validation(Required=false)]
            public string AppSource { get; set; }

            /// <summary>
            /// 应用状态。Enable=启用、Forbidden=禁用、Warring=预警
            /// </summary>
            [NameInMap("appState")]
            [Validation(Required=false)]
            public string AppState { get; set; }

            /// <summary>
            /// 应用显示名称
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// 应用所属的解决方案名称
            /// </summary>
            [NameInMap("solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

        }

        /// <summary>
        /// 提示信息
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
