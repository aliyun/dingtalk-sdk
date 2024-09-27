// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class DigitalStoreSceneScopeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>store</para>
        /// </summary>
        [NameInMap("groupConversationType")]
        [Validation(Required=false)]
        public string GroupConversationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>536239912</para>
        /// </summary>
        [NameInMap("scopeId")]
        [Validation(Required=false)]
        public long? ScopeId { get; set; }

    }

}
