// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CampusListCampusGroupResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<CampusListCampusGroupResponseBodyResult> Result { get; set; }
        public class CampusListCampusGroupResponseBodyResult : TeaModel {
            [NameInMap("extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            [NameInMap("groupDeptId")]
            [Validation(Required=false)]
            public long? GroupDeptId { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

        }

    }

}
