// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class CreateEnterpriseTodoTaskResponseBody : TeaModel {
        [NameInMap("bizCategoryId")]
        [Validation(Required=false)]
        public string BizCategoryId { get; set; }

        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public long? CreatedTime { get; set; }

        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("detailUrl")]
        [Validation(Required=false)]
        public CreateEnterpriseTodoTaskResponseBodyDetailUrl DetailUrl { get; set; }
        public class CreateEnterpriseTodoTaskResponseBodyDetailUrl : TeaModel {
            [NameInMap("appUrl")]
            [Validation(Required=false)]
            public string AppUrl { get; set; }

            [NameInMap("webUrl")]
            [Validation(Required=false)]
            public string WebUrl { get; set; }

        }

        [NameInMap("done")]
        [Validation(Required=false)]
        public bool? Done { get; set; }

        [NameInMap("dueTime")]
        [Validation(Required=false)]
        public long? DueTime { get; set; }

        [NameInMap("executorIds")]
        [Validation(Required=false)]
        public List<string> ExecutorIds { get; set; }

        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        [NameInMap("sourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        [NameInMap("subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("taskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
