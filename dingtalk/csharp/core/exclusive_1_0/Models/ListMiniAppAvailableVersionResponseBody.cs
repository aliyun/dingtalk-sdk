// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkexclusive_1_0.Models
{
    public class ListMiniAppAvailableVersionResponseBody : TeaModel {
        /// <summary>
        /// result
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<ListMiniAppAvailableVersionResponseBodyList> List { get; set; }
        public class ListMiniAppAvailableVersionResponseBodyList : TeaModel {
            /// <summary>
            /// 打包状态，0-打包中，1-成功，2-失败
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

        }

    }

}
