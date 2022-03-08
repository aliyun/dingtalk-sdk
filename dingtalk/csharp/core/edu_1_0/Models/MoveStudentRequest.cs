// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class MoveStudentRequest : TeaModel {
        /// <summary>
        /// 管理员id
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// 愿班级id
        /// </summary>
        [NameInMap("originClassId")]
        [Validation(Required=false)]
        public long? OriginClassId { get; set; }

        /// <summary>
        /// 目标班级id
        /// </summary>
        [NameInMap("targetClassId")]
        [Validation(Required=false)]
        public long? TargetClassId { get; set; }

        /// <summary>
        /// 学生id
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
