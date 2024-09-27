// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreSceneScopeRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cidxxa9122s733s1==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>achieveAllocate</para>
        /// </summary>
        [NameInMap("sceneCode")]
        [Validation(Required=false)]
        public string SceneCode { get; set; }

    }

}
