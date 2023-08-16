// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class TeamTemplatesResponseBody : TeaModel {
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("templateList")]
        [Validation(Required=false)]
        public List<TeamTemplatesResponseBodyTemplateList> TemplateList { get; set; }
        public class TeamTemplatesResponseBodyTemplateList : TeaModel {
            [NameInMap("authorName")]
            [Validation(Required=false)]
            public string AuthorName { get; set; }

            [NameInMap("belong")]
            [Validation(Required=false)]
            public string Belong { get; set; }

            [NameInMap("contentDownloadUrl")]
            [Validation(Required=false)]
            public string ContentDownloadUrl { get; set; }

            [NameInMap("coverDownloadUrl")]
            [Validation(Required=false)]
            public string CoverDownloadUrl { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("usedCount")]
            [Validation(Required=false)]
            public long? UsedCount { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("workspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

    }

}
