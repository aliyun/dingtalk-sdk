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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1</para>
            /// </summary>
            [NameInMap("appVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("appVersionId")]
            [Validation(Required=false)]
            public long? AppVersionId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("appVersionType")]
            [Validation(Required=false)]
            public int? AppVersionType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("miniAppId")]
            [Validation(Required=false)]
            public string MiniAppId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("miniAppOnPc")]
            [Validation(Required=false)]
            public bool? MiniAppOnPc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("modifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
