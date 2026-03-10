// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class IntelligentSendCardRequest : TeaModel {
        [NameInMap("atAll")]
        [Validation(Required=false)]
        public bool? AtAll { get; set; }

        [NameInMap("atOpenGroupRoleIds")]
        [Validation(Required=false)]
        public List<string> AtOpenGroupRoleIds { get; set; }

        [NameInMap("atUnionIds")]
        [Validation(Required=false)]
        public List<string> AtUnionIds { get; set; }

        [NameInMap("atUserIds")]
        [Validation(Required=false)]
        public List<string> AtUserIds { get; set; }

        [NameInMap("excludeIds")]
        [Validation(Required=false)]
        public List<string> ExcludeIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cidt*****Xa4K10w==</para>
        /// </summary>
        [NameInMap("openConversationId")]
        [Validation(Required=false)]
        public string OpenConversationId { get; set; }

        [NameInMap("outTrackId")]
        [Validation(Required=false)]
        public string OutTrackId { get; set; }

        [NameInMap("receivers")]
        [Validation(Required=false)]
        public List<string> Receivers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>axcf*-<em><b><b>-</b></b></em>-23da*</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
