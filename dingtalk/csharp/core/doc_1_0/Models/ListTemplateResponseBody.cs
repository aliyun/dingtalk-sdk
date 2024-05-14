// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkdoc_1_0.Models
{
    public class ListTemplateResponseBody : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("templateList")]
        [Validation(Required=false)]
        public List<ListTemplateResponseBodyTemplateList> TemplateList { get; set; }
        public class ListTemplateResponseBodyTemplateList : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("coverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("docType")]
            [Validation(Required=false)]
            public string DocType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("templateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
