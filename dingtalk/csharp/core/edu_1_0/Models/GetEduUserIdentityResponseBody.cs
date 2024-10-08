// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class GetEduUserIdentityResponseBody : TeaModel {
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

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
