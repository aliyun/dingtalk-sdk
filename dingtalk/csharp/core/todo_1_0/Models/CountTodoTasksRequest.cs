// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_1_0.Models
{
    public class CountTodoTasksRequest : TeaModel {
        [NameInMap("fromDueTime")]
        [Validation(Required=false)]
        public long? FromDueTime { get; set; }

        [NameInMap("isDone")]
        [Validation(Required=false)]
        public bool? IsDone { get; set; }

        [NameInMap("isRecycled")]
        [Validation(Required=false)]
        public bool? IsRecycled { get; set; }

        [NameInMap("roleTypes")]
        [Validation(Required=false)]
        public List<List<string>> RoleTypes { get; set; }

        [NameInMap("toDueTime")]
        [Validation(Required=false)]
        public long? ToDueTime { get; set; }

    }

}
