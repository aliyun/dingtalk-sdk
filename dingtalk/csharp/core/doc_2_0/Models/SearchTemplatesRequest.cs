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

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>next_token</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pc</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("templateTypes")]
            [Validation(Required=false)]
            public List<int?> TemplateTypes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            [NameInMap("workspaceIds")]
            [Validation(Required=false)]
            public List<string> WorkspaceIds { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("param")]
        [Validation(Required=false)]
        public SearchTemplatesRequestParam Param { get; set; }
        public class SearchTemplatesRequestParam : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_template</para>
            /// </summary>
            [NameInMap("belong")]
            [Validation(Required=false)]
            public string Belong { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>searchName</para>
            /// </summary>
            [NameInMap("searchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_id</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

    }

}
