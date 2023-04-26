// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0.Models
{
    public class CustomizeContactDeptListResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<CustomizeContactDeptListResponseBodyContent> Content { get; set; }
        public class CustomizeContactDeptListResponseBodyContent : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("managerIdList")]
            [Validation(Required=false)]
            public List<string> ManagerIdList { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public long? Order { get; set; }

            [NameInMap("parentDeptId")]
            [Validation(Required=false)]
            public long? ParentDeptId { get; set; }

            [NameInMap("refId")]
            [Validation(Required=false)]
            public long? RefId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public long? Type { get; set; }

        }

    }

}
