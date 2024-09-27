// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkh3yun_1_0.Models
{
    public class GetAppsResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetAppsResponseBodyData> Data { get; set; }
        public class GetAppsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>D000183inventory</para>
            /// </summary>
            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Installed</para>
            /// </summary>
            [NameInMap("appSource")]
            [Validation(Required=false)]
            public string AppSource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("appState")]
            [Validation(Required=false)]
            public string AppState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>人事管理</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev001</para>
            /// </summary>
            [NameInMap("solution")]
            [Validation(Required=false)]
            public string Solution { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
