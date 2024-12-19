// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class AddLiveInteractionPluginRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("liveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pluginInfo")]
        [Validation(Required=false)]
        public AddLiveInteractionPluginRequestPluginInfo PluginInfo { get; set; }
        public class AddLiveInteractionPluginRequestPluginInfo : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("anchorJumpUrl")]
            [Validation(Required=false)]
            public string AnchorJumpUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("pluginIconUrl")]
            [Validation(Required=false)]
            public string PluginIconUrl { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("pluginName")]
            [Validation(Required=false)]
            public string PluginName { get; set; }

            [NameInMap("pluginNameEn")]
            [Validation(Required=false)]
            public string PluginNameEn { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("viewerJumpUrl")]
            [Validation(Required=false)]
            public string ViewerJumpUrl { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
