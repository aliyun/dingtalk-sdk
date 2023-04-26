// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CollegeListDeptManagerResponseBody : TeaModel {
        [NameInMap("managerInfoSimpleList")]
        [Validation(Required=false)]
        public List<CollegeListDeptManagerResponseBodyManagerInfoSimpleList> ManagerInfoSimpleList { get; set; }
        public class CollegeListDeptManagerResponseBodyManagerInfoSimpleList : TeaModel {
            [NameInMap("isActive")]
            [Validation(Required=false)]
            public bool? IsActive { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
