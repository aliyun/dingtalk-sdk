// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetEduUserIdentityResponseBody : TeaModel {
        /// <summary>
        /// 返回数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEduUserIdentityResponseBodyData Data { get; set; }
        public class GetEduUserIdentityResponseBodyData : TeaModel {
            [NameInMap("matchGuardianRule")]
            [Validation(Required=false)]
            public bool? MatchGuardianRule { get; set; }
            [NameInMap("matchTeacherRule")]
            [Validation(Required=false)]
            public bool? MatchTeacherRule { get; set; }
            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }
        };

        /// <summary>
        /// 是否查询成功
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
