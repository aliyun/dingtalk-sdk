// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkim_1_0.Models
{
    public class QueryUserGroupAliasTitleResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryUserGroupAliasTitleResponseBodyResult Result { get; set; }
        public class QueryUserGroupAliasTitleResponseBodyResult : TeaModel {
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
