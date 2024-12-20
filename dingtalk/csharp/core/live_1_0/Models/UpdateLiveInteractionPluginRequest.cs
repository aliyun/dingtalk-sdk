// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalklive_1_0.Models
{
    public class UpdateLiveInteractionPluginRequest : TeaModel {
        [NameInMap("anchorJumpUrl")]
        [Validation(Required=false)]
        public string AnchorJumpUrl { get; set; }

        [NameInMap("pluginIconUrl")]
        [Validation(Required=false)]
        public string PluginIconUrl { get; set; }

        [NameInMap("pluginName")]
        [Validation(Required=false)]
        public string PluginName { get; set; }

        [NameInMap("pluginNameEn")]
        [Validation(Required=false)]
        public string PluginNameEn { get; set; }

        [NameInMap("viewerJumpUrl")]
        [Validation(Required=false)]
        public string ViewerJumpUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("liveId")]
        [Validation(Required=false)]
        public string LiveId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
