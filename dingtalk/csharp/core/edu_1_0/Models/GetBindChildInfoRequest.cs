// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetBindChildInfoRequest : TeaModel {
        /// <summary>
        /// 学校id
        /// </summary>
        [NameInMap("schoolCorpId")]
        [Validation(Required=false)]
        public string SchoolCorpId { get; set; }

        /// <summary>
        /// 学生id
        /// </summary>
        [NameInMap("studentUserId")]
        [Validation(Required=false)]
        public string StudentUserId { get; set; }

        /// <summary>
        /// 当前操作人唯一id
        /// </summary>
        [NameInMap("unionId")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

    }

}
