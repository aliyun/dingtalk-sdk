// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListMiniAppHistoryVersionResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListMiniAppHistoryVersionResponseBodyList> List { get; set; }
        public class ListMiniAppHistoryVersionResponseBodyList : TeaModel {
            /// <summary>
            /// 包url
            /// </summary>
            [NameInMap("packageUrl")]
            [Validation(Required=false)]
            public string PackageUrl { get; set; }

            /// <summary>
            /// 包大小
            /// </summary>
            [NameInMap("packageSize")]
            [Validation(Required=false)]
            public string PackageSize { get; set; }

            /// <summary>
            /// 构建状态
            /// </summary>
            [NameInMap("buildStatus")]
            [Validation(Required=false)]
            public long? BuildStatus { get; set; }

            /// <summary>
            /// 版本
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// h5Bundle地址
            /// </summary>
            [NameInMap("h5Bundle")]
            [Validation(Required=false)]
            public string H5Bundle { get; set; }

        }

    }

}
