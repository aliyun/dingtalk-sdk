// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class SearchTaskflowStatusResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<SearchTaskflowStatusResponseBodyResult> Result { get; set; }
        public class SearchTaskflowStatusResponseBodyResult : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("isDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            [NameInMap("isTaskflowstatusruleexector")]
            [Validation(Required=false)]
            public bool? IsTaskflowstatusruleexector { get; set; }

            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("pos")]
            [Validation(Required=false)]
            public int? Pos { get; set; }

            [NameInMap("rejectStatusIds")]
            [Validation(Required=false)]
            public List<string> RejectStatusIds { get; set; }

            [NameInMap("taskflowId")]
            [Validation(Required=false)]
            public string TaskflowId { get; set; }

            [NameInMap("taskflowStatusId")]
            [Validation(Required=false)]
            public string TaskflowStatusId { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

        }

    }

}
