// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkmicro_app_1_0.Models
{
    public class ListInnerAppVersionResponseBody : TeaModel {
        [NameInMap("appVersionList")]
        [Validation(Required=false)]
        public List<ListInnerAppVersionResponseBodyAppVersionList> AppVersionList { get; set; }
        public class ListInnerAppVersionResponseBodyAppVersionList : TeaModel {
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

            [NameInMap("entranceLink")]
            [Validation(Required=false)]
            public string EntranceLink { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("miniAppId")]
            [Validation(Required=false)]
            public string MiniAppId { get; set; }

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

    }

}
