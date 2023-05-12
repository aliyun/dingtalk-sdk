// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkproject_1_0.Models
{
    public class QueryProjectResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<QueryProjectResponseBodyResult> Result { get; set; }
        public class QueryProjectResponseBodyResult : TeaModel {
            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("creatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            [NameInMap("customFields")]
            [Validation(Required=false)]
            public List<QueryProjectResponseBodyResultCustomFields> CustomFields { get; set; }
            public class QueryProjectResponseBodyResultCustomFields : TeaModel {
                [NameInMap("customFieldId")]
                [Validation(Required=false)]
                public string CustomFieldId { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public List<QueryProjectResponseBodyResultCustomFieldsValue> Value { get; set; }
                public class QueryProjectResponseBodyResultCustomFieldsValue : TeaModel {
                    [NameInMap("customFieldValueId")]
                    [Validation(Required=false)]
                    public string CustomFieldValueId { get; set; }

                    [NameInMap("metaString")]
                    [Validation(Required=false)]
                    public string MetaString { get; set; }

                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

            }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("endDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("isArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }

            [NameInMap("isSuspended")]
            [Validation(Required=false)]
            public bool? IsSuspended { get; set; }

            [NameInMap("isTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }

            [NameInMap("logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("projectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("startDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("uniqueIdPrefix")]
            [Validation(Required=false)]
            public string UniqueIdPrefix { get; set; }

            [NameInMap("updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }

            [NameInMap("visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

        }

    }

}
