// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models
{
    public class HrbrainEmpPoolUserResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public HrbrainEmpPoolUserResponseBodyContent Content { get; set; }
        public class HrbrainEmpPoolUserResponseBodyContent : TeaModel {
            [NameInMap("empVos")]
            [Validation(Required=false)]
            public List<HrbrainEmpPoolUserResponseBodyContentEmpVos> EmpVos { get; set; }
            public class HrbrainEmpPoolUserResponseBodyContentEmpVos : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public int? NextToken { get; set; }

            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public bool? Result { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
