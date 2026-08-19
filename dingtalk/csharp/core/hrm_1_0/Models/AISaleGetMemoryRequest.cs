// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkhrm_1_0.Models
{
    public class AISaleGetMemoryRequest : TeaModel {
        [NameInMap("creatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        [NameInMap("customerScopeId")]
        [Validation(Required=false)]
        public string CustomerScopeId { get; set; }

        [NameInMap("entityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        [NameInMap("entityIds")]
        [Validation(Required=false)]
        public List<string> EntityIds { get; set; }

        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("memoryCategory")]
        [Validation(Required=false)]
        public string MemoryCategory { get; set; }

        [NameInMap("minImportance")]
        [Validation(Required=false)]
        public int? MinImportance { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
