// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models
{
    public class GetTemplateListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetTemplateListResponseBodyData> Data { get; set; }
        public class GetTemplateListResponseBodyData : TeaModel {
            [NameInMap("actions")]
            [Validation(Required=false)]
            public List<GetTemplateListResponseBodyDataActions> Actions { get; set; }
            public class GetTemplateListResponseBodyDataActions : TeaModel {
                [NameInMap("actionKey")]
                [Validation(Required=false)]
                public string ActionKey { get; set; }

                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("needReason")]
                [Validation(Required=false)]
                public bool? NeedReason { get; set; }

                [NameInMap("needReasonRequired")]
                [Validation(Required=false)]
                public bool? NeedReasonRequired { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public long? Order { get; set; }

                [NameInMap("styleType")]
                [Validation(Required=false)]
                public long? StyleType { get; set; }

            }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            [NameInMap("modifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("templateKey")]
            [Validation(Required=false)]
            public string TemplateKey { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
