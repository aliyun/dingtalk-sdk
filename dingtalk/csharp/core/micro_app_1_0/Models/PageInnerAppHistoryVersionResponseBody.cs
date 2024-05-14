// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class PageInnerAppHistoryVersionResponseBody : TeaModel {
        [NameInMap("miniAppVersionList")]
        [Validation(Required=false)]
        public List<PageInnerAppHistoryVersionResponseBodyMiniAppVersionList> MiniAppVersionList { get; set; }
        public class PageInnerAppHistoryVersionResponseBodyMiniAppVersionList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appVersionId")]
            [Validation(Required=false)]
            public long? AppVersionId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("appVersionType")]
            [Validation(Required=false)]
            public int? AppVersionType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("miniAppId")]
            [Validation(Required=false)]
            public string MiniAppId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("miniAppOnPc")]
            [Validation(Required=false)]
            public bool? MiniAppOnPc { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
