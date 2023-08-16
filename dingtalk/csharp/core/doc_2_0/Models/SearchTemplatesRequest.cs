// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_2_0.Models
{
    public class SearchTemplatesRequest : TeaModel {
        [NameInMap("option")]
        [Validation(Required=false)]
        public SearchTemplatesRequestOption Option { get; set; }
        public class SearchTemplatesRequestOption : TeaModel {
            [NameInMap("excludeWorkspaceIds")]
            [Validation(Required=false)]
            public List<string> ExcludeWorkspaceIds { get; set; }

            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("templateTypes")]
            [Validation(Required=false)]
            public List<int?> TemplateTypes { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            [NameInMap("workspaceIds")]
            [Validation(Required=false)]
            public List<string> WorkspaceIds { get; set; }

        }

        [NameInMap("param")]
        [Validation(Required=false)]
        public SearchTemplatesRequestParam Param { get; set; }
        public class SearchTemplatesRequestParam : TeaModel {
            [NameInMap("belong")]
            [Validation(Required=false)]
            public string Belong { get; set; }

            [NameInMap("searchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
