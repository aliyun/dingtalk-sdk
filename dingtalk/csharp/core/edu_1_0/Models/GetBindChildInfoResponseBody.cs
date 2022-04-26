// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetBindChildInfoResponseBody : TeaModel {
        /// <summary>
        /// 孩子id
        /// </summary>
        [NameInMap("childUserId")]
        [Validation(Required=false)]
        public string ChildUserId { get; set; }

        /// <summary>
        /// 当前用户id
        /// </summary>
        [NameInMap("currentUserId")]
        [Validation(Required=false)]
        public string CurrentUserId { get; set; }

        /// <summary>
        /// 家庭id
        /// </summary>
        [NameInMap("familyCorpId")]
        [Validation(Required=false)]
        public string FamilyCorpId { get; set; }

    }

}
