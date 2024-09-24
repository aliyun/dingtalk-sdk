// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddCollegeContactUserResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public AddCollegeContactUserResponseBodyResult Result { get; set; }
        public class AddCollegeContactUserResponseBodyResult : TeaModel {
            [NameInMap("createResult")]
            [Validation(Required=false)]
            public int? CreateResult { get; set; }

            [NameInMap("unionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

            [NameInMap("userid")]
            [Validation(Required=false)]
            public string Userid { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
