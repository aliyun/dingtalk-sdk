// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetBindChildInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3000000000307711730</para>
        /// </summary>
        [NameInMap("childUserId")]
        [Validation(Required=false)]
        public string ChildUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3000000000433459511</para>
        /// </summary>
        [NameInMap("currentUserId")]
        [Validation(Required=false)]
        public string CurrentUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ding95eef8003c9ca8ca24f2f5cc6abecb85</para>
        /// </summary>
        [NameInMap("familyCorpId")]
        [Validation(Required=false)]
        public string FamilyCorpId { get; set; }

    }

}
