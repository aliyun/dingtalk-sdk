// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class MoveStudentRequest : TeaModel {
        [NameInMap("dingCorpId")]
        [Validation(Required=false)]
        public string DingCorpId { get; set; }

        [NameInMap("dingIsvOrgId")]
        [Validation(Required=false)]
        public long? DingIsvOrgId { get; set; }

        [NameInMap("dingOauthAppId")]
        [Validation(Required=false)]
        public long? DingOauthAppId { get; set; }

        [NameInMap("dingOrgId")]
        [Validation(Required=false)]
        public long? DingOrgId { get; set; }

        [NameInMap("dingSuiteKey")]
        [Validation(Required=false)]
        public string DingSuiteKey { get; set; }

        [NameInMap("dingTokenGrantType")]
        [Validation(Required=false)]
        public int? DingTokenGrantType { get; set; }

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
